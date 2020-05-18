using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Amnon_sProjects.ShortestPath;
using Amnon_sProjects.ShortestPath.Searchable;

namespace Amnon_sProjects.LightestPath
{
    public partial class LightestPathFrame : UserControl
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

        // ShortestPathData
        private readonly int[,] _grid;

        // Ctor
        public LightestPathFrame()
        {
            this._grid = new int[RowAmount,ColAmount];
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
                    this._grid[row, col] = 1;
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
            if (this._x >= ButtonWidth * ColAmount || this._y >= ButtonHeight * RowAmount) return;
            this._graphics.FillRectangle(new SolidBrush(Color.FromArgb(
                40, 37, 40)), new Rectangle(new Point(this._x,
                this._y), new Size(ButtonWidth, ButtonHeight)));
            this._grid[this._y / ButtonHeight, this._x / ButtonWidth] = int.MaxValue; // Place wall
        }

        private void girdPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (!this._isMoving || this._x == -1 || this._y == -1) return;
            if (this._x >= ButtonWidth * ColAmount || this._y >= ButtonHeight * RowAmount
            || this._x < 0 || this._y < 0) return;
            
            this._graphics.FillRectangle(new SolidBrush(Color.FromArgb(
                40, 37, 40)), new Rectangle(new Point(this._x,
                this._y), new Size(ButtonWidth, ButtonHeight)));

            this._grid[this._y / ButtonHeight,this._x / ButtonWidth] = int.MaxValue; // Place wall

            this._x = (e.X / ButtonWidth) * ButtonWidth;
            this._y = (e.Y / ButtonHeight) * ButtonHeight;
        }

        private void girdPanel_MouseUp(object sender, MouseEventArgs e)
        {
            this._isMoving = false;
            this._x = -1;
            this._y = -1;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            StatePosition startPosition = new StatePosition(StartingPointY, StartingPointX);
            StatePosition endPosition = new StatePosition(EndingPointY, EndingPointX);
            SearchableMatrix problem = new SearchableMatrix(this._grid, startPosition,
                endPosition, RowAmount, ColAmount);
            this.GraphicalPathFinder(problem,true);
        }

        // -------------------------- Path finder algorithm -----------------------
        /**
         * <summary>
         *          Searching the fastest and lightest path to the goal state using
         *          dijkstra and a star algorithm. 
         * </summary>
         * <
         */
        private bool GraphicalPathFinder(ISearchable<StatePosition> searchable , bool isAStar)
        {
            var source = searchable.GetInitialState();
            var minHeap = new Heap<State<StatePosition>>(true);

            // If AStar Apply hFunction 
            if (isAStar)
               searchable.AddHeuristicValues(BuildHeuristicFunction(searchable));

            // Initialize source
            minHeap.Insert(source);

            while (!minHeap.IsEmpty)
            {
                var curr = minHeap.Remove();
               
                // If the algorithm found the goal state
                if (searchable.IsGoalState(curr))
                {
                    this.GraphicalTraceTrack(curr);
                    return true;
                }

                // Color if current state != source
                if (!curr.Equals(source))
                    this._graphics.FillRectangle(new SolidBrush(Color.LightBlue), new Rectangle(new Point(
                        curr.SValue.Col * ButtonWidth, curr.SValue.Row * ButtonHeight),
                        new Size(ButtonWidth, ButtonHeight)));

                // For each state neighbor
                foreach (var neigh in searchable.GetAllPossibleStates(curr))
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
            state = state.Father; 
            while (true)
            {
                // Until we reach start state
                if (state.Father == null) return;
                
                // Color each state
                this._graphics.FillRectangle(new SolidBrush(Color.LawnGreen),
                    new Rectangle(new Point(state.SValue.Col * ButtonWidth,
                        state.SValue.Row * ButtonHeight), new Size(ButtonWidth, ButtonHeight)));

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



/*
 * LinkedHashSet<State<T>> visitedSet = new LinkedHashSet<>(); // A set of states already evaluated
		super.minHeap.add(searchable.getInitialState()); // A priority queue of states to be evaluated
		
		while(!super.minHeap.isEmpty()) {
			State<T> n = super.pollFromHeap();
			visitedSet.add(n);
			if(searchable.isGoalState(n))
				return super.backTrace(n);
			List<State<T>> successors = searchable.getAllPossibleStates(n);
			for(State<T> successor : successors) 
				if(!super.minHeap.contains(successor) && !visitedSet.contains(successor)) {
					successor.setFather(n);
					super.minHeap.add(successor);
				}else if(!visitedSet.contains(successor) && successor.getsCost() < this.getCost(super.minHeap.iterator(), successor) ) {
					super.minHeap.remove(successor);
					super.minHeap.add(successor);
				}	
		}
		return null;
 */
