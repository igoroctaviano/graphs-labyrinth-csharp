//
// Algorithms in Graphs
// Author: Igor Octaviano R. R.
// ID: 501119
// 

using System.Collections;

using PathFinder_501119.Algorithms;

namespace PathFinder_501119.Structure
{
    public class SortedLinkedList
    {
        private const int NOT_FOUND = -1;

        private ArrayList list;
        private NodeComparer nodeComparer;

        public int Count
        {
            get
            {
                return this.list.Count;
            }
        }

        public SortedLinkedList()
        {
            this.list = new ArrayList();
            this.nodeComparer = new NodeComparer();
        }

        public Node NodeAt(int index)
        {
            return (Node)this.list[index];
        }

        public void RemoveAt(int index)
        {
            this.list.RemoveAt(index);
        }

        public int IndexOf(Node node)
        {
            int LIST_SIZE = this.list.Count;
            for (int i = 0; i < LIST_SIZE; i++)
            {
                Node nodeInTheList = (Node)this.list[i];
                if (nodeInTheList.IsMatch(node))
                    return i;
            }

            return NOT_FOUND;
        }

        public int Push(Node node)
        {
            int k = this.list.BinarySearch(node, this.nodeComparer);

            if (k == NOT_FOUND)
                this.list.Insert(0, node);
            else if (k < 0) // Find location by complement.
            {
                k = ~k;
                this.list.Insert(k, node);
            }
            else if (k >= 0)
                this.list.Insert(k, node);

            return k;
        }

        public Node Pop()
        {
            const int FIRST = 0;
            Node node = (Node)this.list[FIRST];
            this.list.RemoveAt(FIRST);
            return node;
        }
    }
}
