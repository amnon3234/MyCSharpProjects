using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Amnon_sProjects.Properties;
using Amnon_sProjects.ShortestPath;
using Amnon_sProjects.ShortestPath.Searchable;

namespace Amnon_sProjects.LightestPath
{
    public partial class LightestPathFrame : UserControl
    {
        // Data
        private static readonly Color StartingPointColor = Color.FromArgb(178, 8, 55);
        private static readonly Color EndingPointColor = Color.Firebrick;
        private static readonly Color MustGoThrewColor = Color.Brown;
        private static readonly Color SlowerColor = Color.DarkKhaki;
        private static readonly Color WallColor = Color.FromArgb(40, 37, 40);
        private static readonly Color EffectColor = Color.LightBlue;
        private static readonly Color PathFoundColor = Color.SeaGreen;
        private static readonly Color BackgroundColor = SystemColors.Control;
        private static readonly Color CubeBorderColor = Color.Black;

        private static readonly Image StartingPointImage = Resources.start;
        private static readonly Image EndingPointImage = Resources.end;
        private static readonly Image MustGoThroughImage = Resources.mustGoThrough;
        private static readonly Image WallImage = Resources.wall;
        private static readonly Image SlowerImage = Resources.slower;
        private static readonly Image PathImage = Resources.path;

        private static readonly object Locker = new object();

        private const int RowAmount = 26;
        private const int ColAmount = 28;
        private const int ButtonWidth = 15;
        private const int ButtonHeight = 15;

        private Point _currStartingPoint;
        private Point _currEndingPoint;
        private Point _mustGoThroughPoint;

        private int _x, _y;

        private bool _isMoving;
        private bool _isMustGoThroughPressed;

        private readonly Size _cubeSize;
        private Color _currBrushColor;
        private Image _currImage;
        private Button _drawingToolPressed;
        private Graphics _graphics;

        private readonly int[,] _grid;

        // Ctor
        public LightestPathFrame()
        {
            this._cubeSize = new Size(ButtonWidth, ButtonHeight);
            this._grid = new int[RowAmount,ColAmount];
            this._isMoving = false;
            this._x = -1;
            this._y = -1;
            InitializeComponent();
        }
        private void ShortestPathFrame_Load(object sender, System.EventArgs e)
        {
            this._mustGoThroughPoint = new Point();
            this._isMustGoThroughPressed = false;
            this._currStartingPoint = new Point(1 * ButtonWidth, 1 * ButtonHeight);
            this._currEndingPoint = new Point(26 * ButtonWidth, 24 * ButtonHeight);
            this._drawingToolPressed = this.buildWall;
            this._graphics = this.girdPanel.CreateGraphics();
            this._currBrushColor = WallColor;
            this._currImage = WallImage;
        }

        // --------------------------- Draw Grid --------------------------
        private void GirdPanel_Paint(object sender, PaintEventArgs e)
        {
            // Draw grid
            for (int row = 0; row < RowAmount; row++)
                for (int col = 0; col < ColAmount; col++)
                {
                    this._grid[row, col] = 1;
                    int x = col * ButtonWidth,
                        y = row * ButtonHeight;
                    Point currPoint = new Point(x, y);
                    this.DrawRectangle(currPoint, CubeBorderColor, this._cubeSize);
                }

            // Present default starting point
            //this.PaintRectangle(this._currStartingPoint, StartingPointColor, this._cubeSize, true);
            this.DrawImage(this._currStartingPoint, this._cubeSize, StartingPointImage);

            // Present default ending point
            //this.PaintRectangle(this._currEndingPoint, EndingPointColor, this._cubeSize, true);
            this.DrawImage(this._currEndingPoint, this._cubeSize, EndingPointImage);

        }

        //---------------------- Buttons click functions ------------------
        private void DrawingToolsButtons_click(object sender, EventArgs e)
        {
            var curr = sender is Button ? (Button)sender : null;
            if (curr == null) return;
            switch (curr.Name)
            {
                case "buildWall":
                    this._currBrushColor = WallColor;
                    this._currImage = WallImage;
                    break;
                case "slower":
                    this._currBrushColor = SlowerColor;
                    this._currImage = SlowerImage;
                    break;
                case "mustGoThrough":
                    this._currBrushColor = MustGoThrewColor;
                    this._currImage = MustGoThroughImage;
                    break;
                case "setStart":
                    this._currBrushColor = StartingPointColor;
                    this._currImage = StartingPointImage;
                    break;
                case "setEnd":
                    this._currBrushColor = EndingPointColor;
                    this._currImage = EndingPointImage;
                    break;
            }
            this._drawingToolPressed = curr;
        }

        private void PathFindingButtons_Click(object sender, EventArgs e)
        {
            var curr = sender is Button ? (Button) sender : null;
            if (curr == null) return;
            switch (curr.Name)
            {
                case "clearButton":
                    // Clear panel
                    this._graphics.Clear(BackgroundColor);
                    
                    // Initialize data  
                    this._mustGoThroughPoint = new Point();
                    this._isMustGoThroughPressed = false;
                    this._currStartingPoint = new Point(1 * ButtonWidth, 1 * ButtonHeight);
                    this._currEndingPoint = new Point(26 * ButtonWidth, 24 * ButtonHeight);
                    this._drawingToolPressed = this.buildWall;
                    this._graphics = this.girdPanel.CreateGraphics();
                    this._currBrushColor = WallColor;

                    // Draw new grid
                    this.GirdPanel_Paint(null, null);
                    break;

                case "runButton":

                    bool funcBool = false;
                    Func<ISearchable<StatePosition>, bool, bool> func;

                    // Set chosen search method
                    switch (this.algorithmChooser.SelectedIndex)
                    {
                        case 0: // AStar
                            funcBool = true;
                            func = GraphicalPathFinder;
                            break;
                        case 1:// Dijkstra
                            func = GraphicalPathFinder;
                            break;
                        default:// Best first search
                            func = GraphicalBestFirstSearch;
                            break;
                    }
                    if (this._isMustGoThroughPressed)
                    {
                        bool result1 = false;
                        Thread t;
                        try
                        {
                            t = new Thread(() =>
                            {
                                // Find path from starting point to must go trough cube
                                result1 = RunAlgorithm(func, funcBool, _grid, new Point(
                                        _currStartingPoint.X / ButtonWidth, _currStartingPoint.Y / ButtonHeight),
                                    new Point(_mustGoThroughPoint.X / ButtonWidth, _mustGoThroughPoint.Y / ButtonHeight));

                                if (!result1)
                                    MessageBox.Show(
                                        @"There is no path between the starting position and the must go through cube");
                            });
                            t.Start();
                        }
                        catch(Exception) { return; }
                        // find path from must go trough cube to ending point
                        bool result2 = RunAlgorithm(func, funcBool, _grid, new Point(
                                _mustGoThroughPoint.X / ButtonWidth, _mustGoThroughPoint.Y / ButtonHeight),
                            new Point(_currEndingPoint.X / ButtonWidth, _currEndingPoint.Y / ButtonHeight));
                        
                        if (!result2)
                            MessageBox.Show(
                                @"There is no path between the must go through cube and the ending position");
                        
                        // Wait for thread
                        t.Join();
                        
                        if (result1 && result2)
                            MessageBox.Show(@"Path found and painted in green");
                    }
                    else
                    {
                        // find path from starting point to ending point
                        bool result = RunAlgorithm(func, funcBool, _grid, new Point(
                                _currStartingPoint.X / ButtonWidth, _currStartingPoint.Y / ButtonHeight),
                            new Point(_currEndingPoint.X / ButtonWidth, _currEndingPoint.Y / ButtonHeight));

                        MessageBox.Show(!result ? 
                            @"There is no path between the starting position and the ending position":
                            @"Path found and painted in green");
                    }
                    break;
            }
        }

        /**
         * <summary>
         *          Get one of the path finding methods , a bool , matrix
         *          ,start point and end point -> create ISearchable problem
         *          and run the given path finding method on it.
         * </summary>
         * <returns>
         *          path finding method output
         * </returns>
         */
        private static bool RunAlgorithm(Func<ISearchable<StatePosition>, bool, bool> func, bool funcBool, int[,] matrix ,
            Point start, Point goal)
        {
            var startPos = new StatePosition(start.Y,start.X);
            var endPos = new StatePosition(goal.Y, goal.X);
            var problem = new SearchableMatrix(matrix, startPos, endPos, RowAmount, ColAmount);
            return func(problem, funcBool);
        }

        // -------------------------- Drawing tools -----------------------
        private void GirdPanel_MouseDown(object sender, MouseEventArgs e)
        {
            this._x = (e.X / ButtonWidth) * ButtonWidth;
            this._y = (e.Y / ButtonHeight) * ButtonHeight;
            if (this._x >= ButtonWidth * ColAmount || this._y >= ButtonHeight * RowAmount) return;

            Point currPoint = new Point(this._x, this._y);
            int num = 0;

            switch (this._drawingToolPressed.Name)
            {
                case "buildWall":
                    this._isMoving = true;
                    num = int.MaxValue;
                    break;
                case "slower":
                    this._isMoving = true;
                    num = 20;
                    break;
                case "mustGoThrough":
                    this.PaintRectangle(this._mustGoThroughPoint, BackgroundColor, this._cubeSize);
                    this.DrawRectangle(this._mustGoThroughPoint, CubeBorderColor, this._cubeSize);
                    this._mustGoThroughPoint = currPoint;
                    this._isMustGoThroughPressed = true;
                    break;
                case "setStart":
                    this.PaintRectangle(this._currStartingPoint, BackgroundColor, this._cubeSize, true);
                    this.DrawRectangle(this._currStartingPoint, CubeBorderColor, this._cubeSize);
                    this._currStartingPoint = currPoint;
                    break;
                case "setEnd":
                    this.PaintRectangle(this._currEndingPoint, BackgroundColor, this._cubeSize, true);
                    this.DrawRectangle(this._currEndingPoint, CubeBorderColor, this._cubeSize);
                    this._currEndingPoint = currPoint;
                    break;
            }

            //this.PaintRectangle(currPoint, this._currBrushColor, this._cubeSize, true);
            this.DrawImage(currPoint, this._cubeSize, this._currImage);
            this._grid[this._y / ButtonHeight, this._x / ButtonWidth] = num;
        }

        private void GirdPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (!this._isMoving || this._x == -1 || this._y == -1) return;
            if (this._x >= ButtonWidth * ColAmount || this._y >= ButtonHeight * RowAmount
            || this._x < 0 || this._y < 0) return;  // Check constrains 

            int num = 0;
            Point currPoint = new Point(this._x, this._y);

            switch (this._drawingToolPressed.Name)
            {
                case "buildWall":
                    num = int.MaxValue;
                    break;
                case "slower":
                    num = 20;
                    break;
            }

            //this.PaintRectangle(currPoint, this._currBrushColor, this._cubeSize);
            this.DrawImage(currPoint, this._cubeSize, this._currImage);

            this._grid[this._y / ButtonHeight,this._x / ButtonWidth] = num; 

            this._x = (e.X / ButtonWidth) * ButtonWidth;
            this._y = (e.Y / ButtonHeight) * ButtonHeight;
        }

        private void GirdPanel_MouseUp(object sender, MouseEventArgs e)
        {
            this._isMoving = false;
            this._x = -1;
            this._y = -1;
        }

        private void PaintRectangle(Point point, Color color, Size size, bool toOverride = false)
        {
            if ( !toOverride && (this._currStartingPoint.Equals(point) || this._currEndingPoint.Equals(point)))
                return;

            SolidBrush currBrush = new SolidBrush(color);
            Rectangle currRectangle = new Rectangle(point, size);
            lock (Locker)
            {
                this._graphics.FillRectangle(currBrush, currRectangle);
            }
        }

        private void DrawRectangle(Point point, Color color, Size size)
        {
            Pen currPen = new Pen(color, 1);
            Rectangle currRectangle = new Rectangle(point, size);
            this._graphics.DrawRectangle(currPen, currRectangle);
        }

        private void DrawImage(Point point, Size size, Image image)
        {
            Rectangle rectangle = new Rectangle(point, size);
            lock (Locker)
            {
                this._graphics.DrawImage(image, rectangle);
            }
        }

        // -------------------------- Path finder algorithm -----------------------
        /**
         * <summary>
         *          Searching the fastest and lightest path to the goal state using
         *          dijkstra and a star algorithm. 
         * </summary>
         * <returns>
         *          There is a path between the two dots ? true : false
         * </returns>
         */
        private bool GraphicalPathFinder(ISearchable<StatePosition> searchable , bool isAStar=false)
        {
            var source = searchable.GetInitialState();
            var minHeap = new Heap<State<StatePosition>>(true);
            var visited = new HashSet<State<StatePosition>>();

            // If AStar Apply hFunction 
            if (isAStar)
               searchable.AddHeuristicValues(BuildHeuristicFunction(searchable));

            // Initialize source
            minHeap.Insert(source);
            visited.Add(source);
            while (!minHeap.IsEmpty)
            {
                var curr = minHeap.Remove();
                visited.Add(curr);
                // If the algorithm found the goal state
                if (searchable.IsGoalState(curr))
                {
                    this.GraphicalTraceTrack(curr);
                    return true;
                }

                // Color if current state != source
                if (!curr.Equals(source))
                    this.PaintRectangle(new Point(curr.SValue.Col * ButtonWidth, curr.SValue.Row * ButtonHeight),
                        EffectColor, this._cubeSize);

                // For each state neighbor
                foreach (var neigh in searchable.GetAllPossibleStates(curr).Where(neigh => 
                    !visited.Contains(neigh)))
                {
                    neigh.Father = curr;
                    if(!minHeap.Contains(neigh))
                        minHeap.Insert(neigh);
                    else
                    {
                        var temp = minHeap.GetElement(neigh);
                        if (temp.SCost <= neigh.SCost) continue;
                        minHeap.Insert(neigh);
                    }
                }
            }

            // There is no path 
            return false;
        }

        /**
         * <summary>
         *          Searching the fastest and lightest path to the goal state using
         *          Best First Search algorithm. 
         * </summary>
         * <returns>
         *          There is a path between the two dots ? true : false
         * </returns>
         */
        private bool GraphicalBestFirstSearch(ISearchable<StatePosition> searchable, bool nothing = false)
        {
            var source = searchable.GetInitialState();
            var minHeap = new Heap<State<StatePosition>>(true); 
            var visitedSet = new HashSet<State<StatePosition>>(); // A set of states already evaluated

            // Initialize source
            minHeap.Insert(source);
            visitedSet.Add(source);

            while (!minHeap.IsEmpty)
            {
                var curr = minHeap.Remove();
                visitedSet.Add(curr);
                
                // If the algorithm found the goal state
                if (searchable.IsGoalState(curr))
                {
                    this.GraphicalTraceTrack(curr);
                    return true;
                }

                // Color if current state != source
                if (!curr.Equals(source))
                    this.PaintRectangle(new Point(curr.SValue.Col * ButtonWidth, curr.SValue.Row * ButtonHeight),
                        EffectColor, this._cubeSize);

                // For each state neighbor
                foreach (var neigh in searchable.GetAllPossibleStates(curr))
                {
                    if (!minHeap.Contains(neigh) && !visitedSet.Contains(neigh))
                    {
                        neigh.Father = curr;
                        minHeap.Insert(neigh);
                    }
                    else if(!visitedSet.Contains(neigh))
                    {
                        var temp = minHeap.GetElement(neigh);
                        if (temp.SCost <= neigh.SCost) continue;
                        minHeap.Remove(temp);
                        minHeap.Insert(neigh);
                    }
                }
            }

            // There is no path 
            return false;
        }
        
        // -------------------------- Help Functions ---------------------------
        /**
         * <summary>
         *      Trace track of the lightest path and painting it in green
         *      This function will skip the first and last nodes so the user
         *      will be able to see the start and end positions
         * </summary>
         */
        private void GraphicalTraceTrack(State<StatePosition> state)
        {
            Thread.Sleep(100);
            state = state.Father; 
            while (true)
            {
                // Until we reach start state
                if (state.Father == null) return;

                // Color each state
                this.PaintRectangle(new Point(state.SValue.Col * ButtonWidth,state.SValue.Row * ButtonHeight),
                    PathFoundColor, this._cubeSize);
                this.DrawImage(new Point(state.SValue.Col * ButtonWidth, state.SValue.Row * ButtonHeight),
                    this._cubeSize, PathImage);

                // Continuing to the next node in the path
                state = state.Father;
            }
        }

        /**
         * <summary>
         *      Create heuristic function based on bfs from dest to source
         * </summary>
         */
        private static int[,] BuildHeuristicFunction(ISearchable<StatePosition> searchable)
        {
            // Applying bfs from dest
            var source = searchable.GetGoalState(); 
            
            // Initializing to infinity  
            int [,] hFunction = new int[RowAmount, ColAmount];
            for (int row = 0; row < RowAmount; row++)
                for (int col = 0; col < ColAmount; col++)
                    hFunction[row, col] = int.MaxValue;
           
            // Initializing starting point to 0
            hFunction[source.SValue.Row, source.SValue.Col] = 0; 
            var queue = new Queue<State<StatePosition>>();
            queue.Enqueue(source);

            // Going threw each state unvisited neighbors and set their distance from the source as their hValue
            while (queue.Any())
            {
                var curr = queue.Dequeue();
                foreach (var neigh in searchable.GetAllPossibleStates(curr).
                    Where(neigh => hFunction[neigh.SValue.Row,neigh.SValue.Col] == int.MaxValue))
                {
                    hFunction[neigh.SValue.Row, neigh.SValue.Col] = hFunction[curr.SValue.Row, curr.SValue.Col] + 1;
                    queue.Enqueue(neigh);
                }
            }

            return hFunction;
        }
    }
}
