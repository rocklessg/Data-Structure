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
                Console.WriteLine(head.Value  + " ");
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
            Console.WriteLine("List is :   ");

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
    }
}
