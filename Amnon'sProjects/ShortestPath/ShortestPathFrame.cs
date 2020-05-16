using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace Amnon_sProjects.ShortestPath
{
    public partial class ShortestPathFrame : UserControl
    {
        // Data
        private int _x, _y;
        private bool _isMoving;
        private Pen _aPen;
        private const int StartingPointX = 1;
        private const int StartingPointY = 1;
        private const int EndingPointX = 38;
        private const int EndingPointY = 38;
        private const int RowAmount = 40;
        private const int ColAmount = 40;
        private const int ButtonWidth = 10;
        private const int ButtonHeight = 10;
        private Graphics _graphics;

        // Ctor
        public ShortestPathFrame()
        {
            this._isMoving = false;
            this._x = -1;
            this._y = -1;
            InitializeComponent();
        }
        private void ShortestPathFrame_Load(object sender, System.EventArgs e)
        {
            this._aPen = new Pen(Color.FromArgb(178, 8, 55), 5);
            this._graphics = this.girdPanel.CreateGraphics();
            this._graphics.SmoothingMode = System.Drawing.
                Drawing2D.SmoothingMode.AntiAlias;
            this._aPen.StartCap = this._aPen.EndCap = System.Drawing.
                Drawing2D.LineCap.Square;
        }

        // --------------------------- Draw Grid --------------------------
        private void girdPanel_Paint(object sender, PaintEventArgs e)
        {
            Pen currPen = new Pen(Color.Black, 1);
            Brush curBrush = new SolidBrush(Color.Firebrick);
            for (int row = 0; row < RowAmount; row++)
                for (int col = 0; col < ColAmount; col++)
                {
                    int x = col * ButtonWidth,
                        y = row * ButtonHeight;
                    this._graphics.DrawRectangle(currPen, new Rectangle(
                        new Point(x, y), new Size(ButtonWidth, ButtonHeight)));
                }

            const int startX = StartingPointX * ButtonWidth,
                startY = StartingPointY * ButtonHeight,
                endX = EndingPointX * ButtonWidth,
                endY = EndingPointY * ButtonHeight;

            this._graphics.FillRectangle(curBrush, new Rectangle(
                new Point(startX, startY), new Size(ButtonWidth, ButtonHeight)));

            this._graphics.FillRectangle(curBrush, new Rectangle(
                new Point(endX, endY), new Size(ButtonWidth, ButtonHeight)));
        }

        // -------------------------- Drawing tools -----------------------
        private void girdPanel_MouseDown(object sender, MouseEventArgs e)
        {
            this._isMoving = true;
            this._x = (e.X / ButtonWidth) * ButtonWidth;
            this._y = (e.Y / ButtonHeight) * ButtonHeight;
        }

        private void girdPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (!this._isMoving || this._x == -1 || this._y == -1) return;
            if (this._x >= ButtonWidth * ColAmount || this._y >= ButtonHeight * RowAmount) return;

            this._graphics.FillRectangle(new SolidBrush(Color.FromArgb(
                40, 37, 40)), new Rectangle(new Point(this._x,
                this._y), new Size(ButtonWidth, ButtonHeight)));

            this._x = (e.X / ButtonWidth) * ButtonWidth;
            this._y = (e.Y / ButtonHeight) * ButtonHeight;
        }

        private void girdPanel_MouseUp(object sender, MouseEventArgs e)
        {
            this._isMoving = false;
            this._x = -1;
            this._y = -1;
        }
    }
}
