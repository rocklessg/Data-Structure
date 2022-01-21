using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class SinglyLinkedList
    {
        /// <summary>
        /// Property field of type Node that takes Head
        /// </summary>
        public Node Head;


        /// <summary>
        /// Constructor, to set Head to null for the initial Node
        /// </summary>
        public SinglyLinkedList()
        {
            Head = null;
        }

        public void TransverseList()
        {
            Node head = Head;
            while (head != null)
            {
                Console.WriteLine(head.Value + " ");
                head = head.Next;
            }
        }

        public void DisplayList()
        {
            Node head;
            if (Head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            Console.Write("List is :   ");

            head = Head;
            while (head != null)
            {
                Console.WriteLine(head.Value + " ");
                head = head.Next;
            }
        }

        public void CountNodes()
        {
            int count = 0;
            Node head = Head;
            while (head != null)
            {
                count++;
                head = head.Next;
            }
            Console.WriteLine("Number of nodes in the list = " + count);
        }

        public bool SearchingForNode(int value)
        {
            int position = 1;
            Node head = Head;
            while (head != null)
            {
                if (head.Value == value)
                    break;
                position++;
                head = head.Next;
            }
            if (head == null)
            {
                Console.WriteLine(value + " not found in the list");
                return false;
            }

            else
            {
                Console.WriteLine(value + " is at position " + position);
                return true;
            }
        }

        public void FindReferenceToLastNode()
        {
            Node head = Head;
            while (head.Next != null)
                head = head.Next;
        }

        public void FindReferenceToSecondToTheLastNode()
        {
            Node head = Head;
            while (head.Next.Next != null)
            {
                head = head.Next;
            }
        }

        public void FindReferenceToNodeValue(int value)
        {
            Node head = Head;
            while (head != null)
            {
                if (head.Value == value)
                    break;
                head = head.Next;
            }
        }

        public void FindReferenceToNodeValuePredecessor(int value)
        {
            Node head = Head;
            while (head != null)
            {
                if (head.Next.Value == value)
                    break;
                head = head.Next;
            }
        }

        public void FindReferenceToNodePosition(int positionValue)
        {
            Node head = Head;
            for (int i = 1; i < positionValue && head != null; i++)
                head = head.Next;
        }

        /// <summary>
        /// This method can also work for Inserting to 
        /// an empty List
        /// </summary>
        /// <param name="value"></param>
        public void InsertNodeToHead(int value)
        {
            Node temp = new Node(value);
            temp.Next = Head;
            Head = temp;
        }
        public void InsertNodeInEmptyList(int value)
        {
            Node temp = new Node(value);
            while (Head == null)
            {
                Head = temp;
            }
        }

        public void InsertNodeToTail(int value)
        {
            Node head;
            Node temp = new Node(value);

            if (Head == null)
            {
                Head = temp;
                return;
            }

            head = Head;
            while (head.Next != null)
                head = head.Next;
            head.Next = temp;
        }

        public void CreateList()
        {
            int number, value;

            Console.WriteLine("Enter the number of nodes : ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number == 0)
                return;
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Enter the value to be inserted : ");
                value = Convert.ToInt32(Console.ReadLine());
                InsertNodeToTail(value);
            }

        }

        public void InsertAfter(int value, int node)
        {
            Node head = Head;
            while (head != null)
            {
                if (head.Value == node)
                    break;
                head = head.Next;
            }

            if (head == null)
                Console.WriteLine(node + " not present in the list");
            else
            {
                Node temp = new Node(value);
                temp.Next = head.Next;
                head.Next = temp;
            }
        }
        public void InsertBefore(int value, int node)
        {
            Node temp;
            if (Head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            // node is first node, new node is to be inserted before the first node
            if (node == Head.Value)
            {
                temp = new Node(value);
                temp.Next = Head;
                Head = temp;
                return;
            }

            //Find reference to predecesor of node parameter
            Node head = Head;
            while (head.Next != null)
            {
                if (head.Next.Value == node)
                    break;
                head = head.Next;
            }

            if (head.Next == null)
                Console.WriteLine(node + " not present in the list");
            else
            {
                temp = new Node(value);
                temp.Next = head.Next;
                head.Next = temp;
            }
        }

        public void InsertAtGivenPosition(int value, int position)
        {
            Node temp;
            int i;
            if (position == 1)
            {
                temp = new Node(value);
                temp.Next = Head;
                Head = temp;
                return;
            }

            Node head = Head;
            for (i = 1; i < position - 1 && head != null; i++) // fine reference to position - 1 node
                head = head.Next;

            if (head == null)
                Console.WriteLine("You can insert upto " + i + "th positon");
            else
            {
                temp = new Node(value);
                temp.Next = head.Next;
                head.Next = temp;
            }
        }

        public void DeleteFirstNode()
        {
            if (Head == null)
                return;
            _ = Head == Head.Next;
        }

        public void DeleteLastNode()
        {
            if (Head == null)
                return;
            if (Head.Next == null)
            {
                Head = null;
                return;
            }
            Node head = Head;
            while (head.Next.Next != null)
                head = head.Next;
            head.Next = null;
        }

        public void DeleteNode(int node)
        {
            if (Head == null)
            {
                Console.WriteLine("List is empty\n");
                return;
            }

            //Deletion of first node
            if (Head.Value == node)
            {
                Head = Head.Next;
                return;
            }

            //Deletion inbetween or at the end
            Node head = Head;
            while (head.Next != null)
            {
                if (head.Next.Value == node)
                    break;
                head = head.Next;
            }

            if (head.Next == null)
                Console.WriteLine($"node {node} is not in the list");
            else
                head.Next = head.Next.Next;
        }

        public void ReverseList()
        {
            Node previous, head, next;
            previous = null;
            head = Head;
            while (head != null)
            {
                next = head.Next;
                head.Next = previous;
                previous = head;
                head = next;
            }
            Head = previous;
        }

        public void BubbleSortByExchangingValue()
        {
            Node end, firstNode, secondNode;

            for (end = null; end != Head.Next; end = firstNode)
            {
                for (firstNode = Head; firstNode.Next != end; firstNode = firstNode.Next)
                {
                    secondNode = firstNode.Next;
                    if (firstNode.Value > secondNode.Value)
                    {
                        int temp = firstNode.Value;
                        firstNode.Value = secondNode.Value;
                        secondNode.Value = temp;   
                    }
                }
            }
        }
        public void BubbleSortByExchangingLinks()
        {
            throw new NotImplementedException();
        }

        public void MergeSort()
        {
            throw new NotImplementedException();
        }
        public void InsertCycle(int value)
        {
            throw new NotImplementedException();
        }

    }
}




















































                            