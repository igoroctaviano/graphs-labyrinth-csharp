//
// Algorithms in Graphs
// Author: Igor Octaviano R. R.
// ID: 501119
// 

using System.Collections;

namespace PathFinder_501119.Structure
{
    class NodeBFS
    {
        public int g;

        public int x;
        public int y;

        private int gCost;

        private NodeBFS goalNode;
        public NodeBFS parentNode;

        public int TotalCost
        {
            get { return g; }
            set { TotalCost = value; }
        }

        public NodeBFS(NodeBFS parentNode, NodeBFS goalNode, int gCost, int x, int y)
        {
            this.x = x;
            this.y = y;

            this.gCost = gCost;
            this.goalNode = goalNode;
            this.parentNode = parentNode;

            this.InitNode();
        }

        private void InitNode()
        {
            this.g = ((this.parentNode != null) ? this.parentNode.g + this.gCost : this.gCost); // One of the two conditionals.
        }

        public int CompareTo(object item)
        {
            NodeBFS auxNode = (NodeBFS)item;
            int cFactor = (this.TotalCost - auxNode.TotalCost);
            return cFactor;
        }

        public bool IsMatch(NodeBFS node)
        {
            if (node != null)
                return (this.x == node.x && this.y == node.y);
            else
                return false;
        }

        public ArrayList GetSuccessors()
        {
            ArrayList successors = new ArrayList();

            for (int xd = -1; xd <= 1; xd++)
            {
                for (int yd = -1; yd <= 1; yd++)
                {
                    int internalX = (this.x + xd);
                    int internalY = (this.y + yd);

                    int gCost = Map.GetMap(internalX, internalY);

                    const int WALL = -1;
                    if (gCost != WALL)
                    {
                        NodeBFS auxNode = new NodeBFS(this, this.goalNode, gCost, internalX, internalY);
                        if (!auxNode.IsMatch(this.parentNode) && !auxNode.IsMatch(this))
                            successors.Add(auxNode);
                    }
                }
            }
            return successors;
        }
    }
}
