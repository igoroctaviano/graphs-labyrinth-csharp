//
// Algorithms in Graphs
// Author: Igor Octaviano R. R.
// ID: 501119
// 

using System.Collections;

using PathFinder_501119.Structure;

namespace PathFinder_501119.Algorithms
{
    public class NodeComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            return ((Node)x).TotalCost - ((Node)y).TotalCost;
        }
    }
}
