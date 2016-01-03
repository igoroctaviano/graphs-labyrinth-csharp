//
// Algorithms in Graphs
// Author: Igor Octaviano R. R.
// ID: 501119
// 

using System;
using System.Collections;

using PathFinder_501119.Structure;

namespace PathFinder_501119.Algorithms
{
    class BFS
    {
        private const int G_COST = 1;
        private const int MAP_SIZE = 10;
        private const int START_POINT = 0;

        private NodeBFS startNode;
        private NodeBFS goalNode;

        // Data structures.
        private Queue queue;

        private ArrayList solutionPathList;
        private ArrayList ignoredPathList;

        public ArrayList SolutionPath
        {
            get { return this.solutionPathList; }
        }

        public ArrayList IgnoredSolutionPath
        {
            get { return this.ignoredPathList; }
        }

        public BFS()
        {
            this.Init();
        }

        private void Init()
        {
            this.queue = new Queue();

            this.solutionPathList = new ArrayList();
            this.ignoredPathList = new ArrayList();

            this.startNode = new NodeBFS(null, this.goalNode, G_COST, START_POINT, START_POINT);
            this.goalNode = new NodeBFS(null, null, G_COST, MAP_SIZE, MAP_SIZE);
        }

        [STAThread]
        public ArrayList GetSolutionPath()
        {
            this.Init();

            // Put the start node on the queue.
            this.queue.Enqueue(this.startNode);

            // Put the start node on the ignored path list
            // to see how the algorithm behave later
            this.ignoredPathList.Add(this.startNode);

            while (this.queue.Count > 0)
            {
                // Get the node off the queue and call it current node.
                NodeBFS nodeCurrent = (NodeBFS)this.queue.Dequeue();

                // If the current node is the same state 
                // as the goal node we have found the solution;
                if (nodeCurrent.IsMatch(this.goalNode))
                {
                    this.goalNode.parentNode = nodeCurrent.parentNode;
                    break;
                }

                // Generate each state nodeSuccessor that can come after the current node.
                ArrayList successors = nodeCurrent.GetSuccessors();

                foreach (NodeBFS nodeSuccessor in successors)
                {
                    // Remove occurences of nodeSuccessor from the queue.
                    this.Remove(nodeSuccessor);

                    // Add nodeSuccessor to the queue.
                    this.queue.Enqueue(nodeSuccessor);

                    // Add node current to the ignored list to see
                    // how the algorithm behave later.
                    bool exists = false;
                    foreach (NodeBFS node in ignoredPathList)
                    {
                        if (node.IsMatch(nodeSuccessor))
                            exists = true;
                    }
                    if (!exists)
                    {
                        if (!this.ignoredPathList.Contains(nodeSuccessor))
                            this.ignoredPathList.Add(nodeSuccessor);
                    }
                }
            }

            // Follow the parentNode from the goal node
            // to the start node to find solution.
            NodeBFS goal = this.goalNode;
            while (goal != null)
            {
                this.solutionPathList.Insert(0, goal);
                goal = goal.parentNode; // Adjacent node.
            }

            // Return solution path.
            return this.solutionPathList;
        }

        private void Remove(NodeBFS node)
        {
            Queue auxQueue = (Queue)this.queue.Clone();
            this.queue.Clear();

            while (auxQueue.Count > 0)
            {
                NodeBFS item = (NodeBFS)auxQueue.Dequeue();
                if (!item.IsMatch(node))
                    this.queue.Enqueue(item);
            }
        }
    }
}
