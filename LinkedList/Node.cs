using System;

namespace LinkedList
{
    public class Node
    {
        /// <summary>
        /// property field to set value and next(pointer) to the next Node
        /// </summary>
        public int Value;
        public Node Next;

        /// <summary>
        /// Constructor, feeding value with real data and 
        /// Next to null for the first Node
        /// </summary>
        /// <param name="value"></param>
        public Node(int value)
        {
            Value = value;
            Next = null;
        }
    }
}
