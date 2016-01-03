//
// Algorithms in Graphs
// Author: Igor Octaviano R. R.
// ID: 501119
// 

using System;
using System.Collections;

namespace PathFinder_501119.Structure
{
    public enum HeuristicFormula
    {
        Manhattan = 0,
        Euclidean = 1
    }

    public class Node : IComparable
    {
        public int g;
        public int h;

        public int x;
        public int y;

        private int gCost;

        private Node goalNode;
        public Node parentNode;

        private HeuristicFormula formula;
        public HeuristicFormula Formula
        {
            get { return this.formula; }
            set { this.formula = value; }
        }

        public int TotalCost
        {
            get { return (g + h); }
            set { TotalCost = value; }
        }

        public Node(Node parentNode, Node goalNode, int gCost, HeuristicFormula heuristicFormula, int x, int y)
        {
            this.x = x;
            this.y = y;

            this.gCost = gCost;
            this.goalNode = goalNode;
            this.parentNode = parentNode;

            this.formula = heuristicFormula;

            this.InitNode();
        }

        private void InitNode()
        {
            this.g = ((this.parentNode != null) ? this.parentNode.g + this.gCost : this.gCost); // One of the two conditionals.
            this.h = ((this.goalNode != null) ? this.Heuristic() : 0); // One of the two conditionals.
        }

        private int Heuristic()
        {
            switch (Formula)
            {
                case HeuristicFormula.Euclidean:
                    return (int)EuclideanHeuristic();
                case HeuristicFormula.Manhattan:
                    return (int)ManhattanHeuristic();
                default:
                    return (int)ManhattanHeuristic();
            }
        }

        private double EuclideanHeuristic()
        {
            double xd = (this.x - this.goalNode.x);
            double yd = (this.y - this.goalNode.y);

            return Math.Sqrt((xd * xd) + (yd * yd));
        }

        private double ManhattanHeuristic()
        {
            double xd = (Math.Abs(this.x - this.goalNode.x));
            double yd = (Math.Abs(this.y - this.goalNode.y));

            return (xd + yd);
        }

        public int CompareTo(object item)
        {
            Node auxNode = (Node)item;
            int cFactor = (this.TotalCost - auxNode.TotalCost);
            return cFactor;
        }

        public bool IsMatch(Node node)
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
                        Node auxNode = new Node(this, this.goalNode, gCost, Formula, internalX, internalY);
                        if (!auxNode.IsMatch(this.parentNode) && !auxNode.IsMatch(this))
                            successors.Add(auxNode);
                    }
                }
            }
            return successors;
        }
    }
}
