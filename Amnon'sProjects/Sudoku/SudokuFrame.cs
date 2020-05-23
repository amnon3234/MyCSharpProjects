using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amnon_sProjects.Sudoku
{
    public partial class SudokuFrame : UserControl
    {
        // Data
        private static readonly Color FirstColor = Color.LightCoral;
        private static readonly Color SecondColor = Color.LightSlateGray;
        private static readonly Color ButtonForeColor = Color.Black;
        private static readonly Color ProblemColor = Color.Red;
        private static readonly Color FinishColor = Color.Green;

        private const int ButtonWidth = 34;
        private const int ButtonHeight = 34;
        private const int SpaceBetweenButtons = 5;
        private const int RowAmount = 9;
        private const int ColAmount = 9;
        private const int Easy = 40, Advanced = 54, Hard= 62;

        private readonly List<List<CubeButton>> _buttons;
        private CubeButton _pressed;

        private int _numOfZeroes;
        private int _problemNumber;
        private int[,] _currBoardWithZeroes;
        private int[,] _currBoard;
        private bool _haveSolution;


        private class CubeButton : Button
        {
            public int Row { get; set; }
            public int Col { get; set; }
        }
        
        public SudokuFrame()
        {
            this._problemNumber = 0;
            this._numOfZeroes = 62;
            this._haveSolution = false;
            this._buttons = new List<List<CubeButton>>();
            InitializeComponent();
        }

        private void SudokuFrame_Load(object sender, EventArgs e)
        {
            this.difficulty.SelectedIndex = 0;
            this.DrawABoard();
            this.UpdateBoardButtonsValue();
        }

        //------------------------ Draw the board inside game-board panel -----------------------

        private void DrawABoard()
        {
            bool colorFlag = true;

            for (int row = 0; row < RowAmount; row++)
            {
                List<CubeButton> newRow = new List<CubeButton>();
                this._buttons.Add(newRow);
                if (row % 3 == 0 && row != 0) colorFlag = !colorFlag;

                for (var col = 0; col < ColAmount; col++)
                {
                    var cube = new CubeButton();
                    this.CustomizeCube(cube, row, col);

                    if (col % 3 == 0 && col != 0) colorFlag = !colorFlag;
                    cube.BackColor = colorFlag ? FirstColor : SecondColor;
                    newRow.Add(cube);
                    this.panel1.Controls.Add(cube);
                }
            }
        }

        private void ColorBoard()
        {
            var colorFlag = true;
            for (var row = 0; row < RowAmount; row++)
            {
                if (row % 3 == 0 && row != 0) colorFlag = !colorFlag;
                for (var col = 0; col < ColAmount; col++)
                {
                    var cube = this._buttons[row][col];
                    if (col % 3 == 0 && col != 0) colorFlag = !colorFlag;
                    cube.BackColor = colorFlag ? FirstColor : SecondColor;
                }
            }
        }

        private void CustomizeCube(CubeButton cube, int row, int col)
        {
            cube.Size = new Size(ButtonWidth, ButtonHeight);
            cube.FlatStyle = FlatStyle.Flat;
            cube.FlatAppearance.BorderSize = 0;
            cube.Font = new Font("Century Gothic", 10, FontStyle.Bold);
            cube.Tag = row + ";" + col;
            cube.Click += this.gameBoardButton_Click;
            cube.KeyPress += SudokuFrame_KeyPress;
            cube.ForeColor = ButtonForeColor;
            cube.Top = row * (ButtonHeight + SpaceBetweenButtons);
            cube.Left = col * (ButtonWidth + SpaceBetweenButtons);
            cube.Row = row;
            cube.Col = col;
        }
        //-----------------------------  Generate Sudoku board   --------------------------------
        private void UpdateBoardButtonsValue()
        {
            var generator = new SudokuGenerator();
            this._currBoard = generator.GetGeneratedBoard();
            this._haveSolution = true;
            var boardToSolve = this.PlaceZeroes(this._currBoard);
            for (var row = 0; row < RowAmount; row++)
                for (var col = 0; col < ColAmount; col++)
                {
                    this._buttons[row][col].Text = boardToSolve[row, col] != 0 ? boardToSolve[row, col].ToString() : "";
                    this._buttons[row][col].Enabled = boardToSolve[row, col] == 0;
                }
        }
        private int[,] PlaceZeroes(int[,] board)
        {
            this._currBoardWithZeroes = (int[,])board.Clone();
            while (this._numOfZeroes != 0)
            {
                var rnd = new Random();
                int row = rnd.Next(RowAmount), col = rnd.Next(ColAmount);
                if (this._currBoardWithZeroes[row, col] == 0)
                    continue;
                this._currBoardWithZeroes[row, col] = 0;
                this._numOfZeroes--;
            }
            return this._currBoardWithZeroes;
        }

        //----------------------------- Buttons click functions --------------------------------
        private void gameBoardButton_Click(object sender, EventArgs e)
        {
            if (this._pressed != null)
                this._pressed.FlatAppearance.BorderSize = 0;
            this._pressed = (CubeButton)sender;
            this._pressed.FlatAppearance.BorderSize = 1;
            // Take the focus away from the clicked button
        }

        private void GameButtons_Click(object sender, EventArgs e)
        {
            var curr = sender is Button ? (Button) sender : null;
            if (curr == null) return;
            switch (curr.Name)
            {
                case "clear":
                
                    this.ColorBoard();
                    this._haveSolution = false;
                    this._currBoard = new int[RowAmount, ColAmount];
                    for (var row = 0; row < RowAmount; row++)
                    for (var col = 0; col < ColAmount; col++)
                    {
                        this._currBoard[row, col] = 0;
                        this._currBoardWithZeroes[row, col] = 0;
                        this._buttons[row][col].Text = "";
                        this._buttons[row][col].Enabled = true;
                        this._buttons[row][col].FlatAppearance.BorderSize = 0;
                    }

                    break;
                case "generate": 
                    switch (this.difficulty.SelectedIndex)
                    {
                        case 0:
                            this._numOfZeroes = Hard;
                            break;
                        case 1:
                            this._numOfZeroes = Advanced;
                            break;
                        default:
                            this._numOfZeroes = Easy;
                            break;
                    }

                    this.UpdateBoardButtonsValue();
                    break;
                case "solve":
                    if (!this._haveSolution)
                        #pragma warning disable 4014
                        GraphicalSolverAsync(this._currBoard);
                        #pragma warning restore 4014

                    for (var row = 0; row < RowAmount; row++)
                    for (var col = 0; col < ColAmount; col++)
                        this._buttons[row][col].Text = this._currBoard[row, col].ToString();
                    break;
            }
        }

        // ------------------------------- Key press functions -------------------------------------
        private void SudokuFrame_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
                return;

            int row = this._pressed.Row, col = this._pressed.Col;
            var problems = SudokuSolver.IsValid(this._currBoardWithZeroes,
                this._currBoardWithZeroes[row, col], new SudokuSolver.Cube(row, col));
            foreach (var cube in problems)
            {
                this._problemNumber--;
                this._buttons[cube.CubeRow][cube.CubeCol].FlatAppearance.BorderSize = 0;
                this._buttons[cube.CubeRow][cube.CubeCol].FlatAppearance.BorderColor = Color.Black;
            }
               
            this._pressed.Text = e.KeyChar.ToString();
            this._currBoardWithZeroes[row, col] = e.KeyChar - '0';
            
            problems = SudokuSolver.IsValid(this._currBoardWithZeroes,
               this._currBoardWithZeroes[row,col], new SudokuSolver.Cube(row,col) );
            foreach (var cube in problems)
            {
                this._problemNumber++;
                this._buttons[cube.CubeRow][cube.CubeCol].FlatAppearance.BorderSize = 3;
                this._buttons[cube.CubeRow][cube.CubeCol].FlatAppearance.BorderColor = ProblemColor;
            }

            if (this._problemNumber == 0 && SudokuSolver.FindFirstEmpty(this._currBoardWithZeroes) == null)
            {
                for (var r = 0; r < RowAmount; r++)
                    for (var c = 0; c < ColAmount; c++)
                        this._buttons[r][c].BackColor = FinishColor;
                MessageBox.Show(@"Congrats.... you completed the sudoku");
            }


        }

        // ------------------------------- Sudoku Graphical Solver ----------------------------------   
        /**
         * <summary>
         *      Graphical sudoku solver algorithm by using backTrace algorithm
         * </summary>
         */
        private async Task<bool> GraphicalSolverAsync(int[,] aBoard)
        {
            var firstEmpty = SudokuSolver.FindFirstEmpty(aBoard);
            if (firstEmpty == null)
                return true;
            
            int row = firstEmpty.CubeRow, col = firstEmpty.CubeCol;
            var curr = this._buttons[row][col];
            var currColor = curr.BackColor;
            curr.BackColor = FinishColor;
            await Task.Delay(1);
            for (var index = 1; index < 10; index++)
                if (SudokuSolver.IsValid2(aBoard, index, firstEmpty))
                {
                    aBoard[row, col] = index;
                    curr.Text = index.ToString();
                    if (await this.GraphicalSolverAsync(aBoard))
                        return true;
                    aBoard[row, col] = 0;
                    curr.Text = @"0";
                }

            curr.BackColor = currColor;
            return false; // there is no solution
        }
    }
}

