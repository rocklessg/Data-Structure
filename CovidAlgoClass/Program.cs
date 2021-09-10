using System;
using LinkedList;


namespace CovidAlgoClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice, value, k, x;

            SinglyLinkedList list = new SinglyLinkedList();

            list.CreateList();

            while (true)
            {
                Console.WriteLine("1.Display list");
                Console.WriteLine("2.Count number of nodes");
                Console.WriteLine("3.Search value");
                Console.WriteLine("4.Insert value in empty list/to head");
                Console.WriteLine("5.Insert value to tail");
                Console.WriteLine("6.Insert after a specific node");
                Console.WriteLine("7.Insert before a specific node");
                Console.WriteLine("8.Insert at a givien posistion");
                Console.WriteLine("9.Delete first node");
                Console.WriteLine("10.Delete last node");
                Console.WriteLine("11.Delete any node");
                Console.WriteLine("12.Reverse the list");
                Console.WriteLine("13.Bubble sort by exchanging value");
                Console.WriteLine("14.Bubble sort by exchanging next");
                Console.WriteLine("15.MergeSort");
                Console.WriteLine("16.Insert Cycle");
                Console.WriteLine("17.Detect Cycle");
                Console.WriteLine("18.Remove Cycle");
                Console.WriteLine("19.Quit");

                Console.WriteLine("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 19)
                    break;

                switch (choice)
                {
                    case 1:
                        list.DisplayList();
                        break;
                    case 2:
                        list.CountNodes();
                        break;
                    case 3:
                        Console.WriteLine("Enter value to be searched : ");
                        value = Convert.ToInt32(Console.ReadLine());
                        list.SearchingForNode(value);
                        break;
                    case 4:
                        Console.WriteLine("Enter value to be inserted: ");
                        value = Convert.ToInt32(Console.ReadLine());
                        list.InsertNodeToHead(value);
                        break;
                    case 5:
                        Console.WriteLine("Enter value to be inserted: ");
                        value = Convert.ToInt32(Console.ReadLine());
                        list.InsertNodeToTail(value);
                        break;
                    case 6:
                        Console.WriteLine("Enter value to be inserted : ");
                        value = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter value after which to insert: ");
                        k = Convert.ToInt32(Console.ReadLine());
                        list.FindReferenceToNodePosition(k);
                        break;

                }
            }
        }
    }
}
