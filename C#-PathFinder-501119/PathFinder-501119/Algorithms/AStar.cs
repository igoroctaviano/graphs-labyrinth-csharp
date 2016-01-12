//
// Disciplina: Algoritmos em Grafos
// *Discipline: Algorithms in Graphs
// Igor Octaviano
// https://github.com/igoroctaviano
//
using System;
using System.Collections;

using PathFinder_501119.Structure;

namespace PathFinder_501119.Algorithms
{
    class AStar
    {
        private const int G_COST = 1;
        private const int MAP_SIZE = 10;
        private const int START_POINT = 0;

        private Node startNode;
        private Node goalNode;

        // Data structures.
        private ArrayList solutionPathList;
        private ArrayList ignoredPathList;

        private SortedLinkedList openList; 
        private SortedLinkedList closedList; 

        private HeuristicFormula formula;
        public HeuristicFormula Formula
        {
            get { return this.formula; }
            set { this.formula = value; }
        }

        public ArrayList SolutionPath
        {
            get { return this.solutionPathList; }
        }

        public ArrayList IgnoredSolutionPath
        {
            get { return this.ignoredPathList; }
        }

        private void Init()
        {
            this.solutionPathList = new ArrayList();
            this.ignoredPathList = new ArrayList();

            this.startNode = new Node(null, this.goalNode, G_COST, this.formula, START_POINT, START_POINT);
            this.goalNode = new Node(null, null, G_COST, this.formula, MAP_SIZE, MAP_SIZE);

            this.openList = new SortedLinkedList();
            this.closedList = new SortedLinkedList();
        }

        [STAThread]
        public ArrayList GetSolutionPath()
        {
            this.Init();

            // Put the start node on the open list.
            this.openList.Push(this.startNode);

            // Put the start node on the ignored path list
            // to see how the algorithm behave later
            this.ignoredPathList.Add(this.startNode);

            while (!IsEmpty(this.openList))
            {
                // Get the node off the open list
                // with the lowest f and call it current node.
                Node nodeCurrent = this.openList.Pop();

                // If the current node is the same state 
                // as the goal node we have found the solution;
                if (nodeCurrent.IsMatch(this.goalNode))
                {
                    this.goalNode.parentNode = nodeCurrent.parentNode;
                    break;
                }

                // Generate each state nodeSuccessor that can come after the current node.
                ArrayList successors = nodeCurrent.GetSuccessors();
                foreach (Node nodeSuccessor in successors)
                {
                    // Set the cost of nodeSuccessor to be the cost of the current node plus
                    // the cost to get to nodeSuccessor from the current node
                    // --> already set while we are getting successors.

                    // Find nodeSuccessor on the open list.
                    int openFound = this.openList.IndexOf(nodeSuccessor);

                    // If nodeSuccessor is on the open list but the existing one is as good
                    // or better then discard this successor and continue.
                    if (openFound > 0)
                    {
                        Node existingNode = this.openList.NodeAt(openFound);
                        if (existingNode.CompareTo(nodeCurrent) <= 0)
                            continue;
                    }

                    // Find index of nodeSuccessor on the closedList.
                    int closedFound = this.closedList.IndexOf(nodeSuccessor);

                    // If nodeSuccessor is on the closed list but the existing one is as good
                    // or better then discard this successor and continue.
                    if (closedFound > 0)
                    {
                        Node existingNode = this.closedList.NodeAt(closedFound);
                        if (existingNode.CompareTo(nodeCurrent) <= 0)
                            continue;
                    }

                    // Remove occurences of nodeSuccessor from the open list and the closed list.
                    const int NOT_FOUND = -1;
                    if (openFound != NOT_FOUND)
                        this.openList.RemoveAt(openFound);
                    if (closedFound != NOT_FOUND)
                        this.closedList.RemoveAt(closedFound);

                    // Set the parent of nodeSuccessor to the current node.
                    // --> already set while we are getting successors.

                    // Set h to be the estimated distance to goal node (Using heuristic function).
                    // --> already set while we are getting successors.

                    // Add nodeSuccessor to the open list.
                    this.openList.Push(nodeSuccessor);

                    // Add node successor to the ignored list to see
                    // how the algorithm behave later.
                    this.ignoredPathList.Add(nodeSuccessor);
                }

                // Add current node to the closed list.
                this.closedList.Push(nodeCurrent);
            }

            // Follow the parentNode from the goal node
            // to the start node to find solution.
            Node goal = this.goalNode;
            while (goal != null)
            {
                this.solutionPathList.Insert(0, goal);
                goal = goal.parentNode; // Adjacent node.
            }

            // Return solution path.
            return this.solutionPathList;
        }

        private bool IsEmpty(SortedLinkedList list) { return (list.Count == 0); }
    }
}
