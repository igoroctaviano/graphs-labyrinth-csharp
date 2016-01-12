//
// Disciplina: Algoritmos em Grafos
// *Discipline: Algorithms in Graphs
// Igor Octaviano
// https://github.com/igoroctaviano
//
using System.Drawing;
using System.Threading;
using System.Collections;
using System.Windows.Forms;

namespace PathFinder_501119.Structure
{
    class Map
    {
        const int ROAD = 1;
        const int WALL = -1;

        const int DEFAULT_DELAY_VALUE = 200;

        private Thread thread;

        private Button[,] buttons;
        private FlowLayoutPanel flp;
        private int sequentialPosition;

        private ArrayList solutionPathList;
        private ArrayList ignoredSolutionPathList;

        public static int xMax;
        public static int yMax;

        private static readonly Color PATH_COLOR = Color.White;
        private static readonly Color WALL_COLOR = Color.Gray;
        private static readonly Color ROAD_COLOR = Color.Red;
        private static readonly Color IGNORED_COLOR = Color.LightSkyBlue;

        private int delay;
        public int Delay
        {
            get { return this.delay; }
            set { this.delay = value; }
        }

        static int[,] mapData =
        {
            { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
            { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
            { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
            { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
            { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
            { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
            { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
            { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
            { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
            { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
            { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}
        };

        public Map(FlowLayoutPanel flp, Button[,] buttons)
        {
            this.delay = DEFAULT_DELAY_VALUE;

            this.flp = flp;
            this.buttons = buttons;
            this.sequentialPosition = 0;

            this.solutionPathList = new ArrayList();
            this.ignoredSolutionPathList = new ArrayList();

            xMax = mapData.GetUpperBound(0);
            yMax = mapData.GetUpperBound(1);
        }

        public void Reset()
        {
            for (int x = 0; x < xMax + 1; x++) // + 1
            {
                for (int y = 0; y < yMax + 1; y++) // + 1
                {
                    if (mapData[x, y] == WALL)
                        mapData[x, y] = ROAD;
                }
            }

            this.PrintWalls();
        }

        public void InsertWall(int x, int y)
        {
            if (AllowedNodes(x, y))
                mapData[x, y] = WALL;

            this.PrintWalls();
        }

        public static int GetMap(int x, int y)
        {
            if (x < 0 || x > xMax)
                return -1;
            else if (y < 0 || y > yMax)
                return -1;
            else
                return mapData[x, y];
        }

        private void PrintWalls()
        {
            this.sequentialPosition = 0;
            for (int x = 0; x <= xMax; x++)
            {
                for (int y = 0; y <= yMax; y++)
                {
                    if (AllowedNodes(x, y))
                    {
                        if (Map.GetMap(x, y) == WALL)
                            this.ColorTheButton(buttons[x, y], WALL_COLOR);
                        else
                            this.ColorTheButton(buttons[x, y], PATH_COLOR);
                    }

                    this.sequentialPosition++;
                }
            }
        }

        public bool AllowedNodes(int x, int y)
        {
            if (x == y)
            {
                if (y == 0)
                    return false;
                else if (y == yMax)
                    return false;
            }
            return true;
        }

        public void PrintSolution(ArrayList solutionPathList, ArrayList ignoredPathList)
        {
            // Get the current solution.
            this.solutionPathList = solutionPathList;

            // Get the current ignored solution.
            this.ignoredSolutionPathList = ignoredPathList;

            // Print all the used nodes and the optimal solution.
            this.PrintIgnoredSolutionAStar();
        }

        private void PSAS()
        {
            foreach (Node node in this.solutionPathList)
            {
                this.sequentialPosition = 0;
                for (int x = 0; x <= xMax; x++)
                {
                    for (int y = 0; y <= yMax; y++)
                    {
                        Node tmp = new Node(null, null, 0, node.Formula, x, y);
                        if (node.IsMatch(tmp))
                        {
                            if (AllowedNodes(x, y))
                            {
                                this.ColorTheButton(buttons[x, y], ROAD_COLOR);

                                y = yMax;
                                x = xMax;
                            }
                        }

                        this.sequentialPosition++;
                    }
                }

                Thread.Sleep(Delay);
            }

            this.thread.Join();
            this.thread.Abort();
        }

        private void PrintIgnoredSolutionAStar()
        {
            this.thread = new Thread(PISAS);
            this.thread.Start();
        }
        private void PISAS()
        {
            foreach (Node node in this.ignoredSolutionPathList)
            {
                this.sequentialPosition = 0;
                for (int x = 0; x <= xMax; x++)
                {
                    for (int y = 0; y <= yMax; y++)
                    {
                        Node tmp = new Node(null, null, 0, node.Formula, x, y);
                        if (node.IsMatch(tmp))
                        {
                            if (AllowedNodes(x, y))
                            {
                                this.ColorTheButton(buttons[x, y], IGNORED_COLOR);

                                y = yMax;
                                x = xMax;
                            }
                        }

                        this.sequentialPosition++;
                    }
                }

                Thread.Sleep(Delay);
            }

            // Print the optimal solution.
            this.thread = new Thread(PSAS);
            this.thread.Start();

            this.thread.Join();
            this.thread.Abort();
        }

        public void ClearSolution()
        {
            this.thread = new Thread(CSAS);
            this.thread.Start();
        }
        public void CSAS()
        {
            foreach (Node node in this.ignoredSolutionPathList)
            {
                this.sequentialPosition = 0;
                for (int x = 0; x <= xMax; x++)
                {
                    for (int y = 0; y <= yMax; y++)
                    {
                        Node tmp = new Node(null, null, 0, node.Formula, x, y);
                        if (node.IsMatch(tmp))
                        {
                            if (AllowedNodes(x, y))
                            {
                                this.ColorTheButton(buttons[x, y], PATH_COLOR);
                                mapData[x, y] = ROAD;

                                y = yMax;
                                x = xMax;
                            }
                        }

                        this.sequentialPosition++;
                    }
                }
            }

            this.thread.Join();
            this.thread.Abort();
        }

        private void ColorTheButton(Button button, Color color)
        {
            button.BackColor = color;
            this.flp.Controls.SetChildIndex(button, this.sequentialPosition);
        }
    }
}
