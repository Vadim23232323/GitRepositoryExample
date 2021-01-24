using System;
using System.Collections.Generic;
using System.Linq;

namespace HW_1.task3_LinkedList
{
    public static class LinkedListExample
    {
        public static void ShowLinkedList()
        {
            LinkedList<string> months = new LinkedList<string>();

            // Добавлять элемент в связный список мы можем 4 способами
           months.AddFirst("January");
           months.AddAfter(months.Last, "February");
           months.AddAfter(months.Last, "March");
           months.AddAfter(months.Last, "April");
           months.AddAfter(months.Last, "May");
           months.AddAfter(months.Last, "June");
           months.AddAfter(months.Last, "July");
           months.AddAfter(months.Last, "August");
           months.AddAfter(months.Last, "September");
           months.AddAfter(months.Last, "October");
           months.AddBefore(months.Last, "November");
           months.AddLast("December");

            LinkedListNode<string> currentNode =months.First;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Next;
            }
        }

        public static void RemoveNode()
        {
            LinkedList<string>months = new LinkedList<string>();

            months.AddFirst("January");
            months.AddAfter(months.Last, "February");
            months.AddAfter(months.Last, "March");
            months.AddAfter(months.Last, "April");
            months.AddAfter(months.Last, "May");
            months.AddAfter(months.Last, "June");
            months.AddAfter(months.Last, "July");
            months.AddAfter(months.Last, "August");
            months.AddAfter(months.Last, "September");
            months.AddAfter(months.Last, "October");
            months.AddBefore(months.Last, "November");
            months.AddLast("December");

            months.Remove(months.ElementAt(5));
           

            LinkedListNode<string> currentNode =months.First;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Next;
            }
        }

    }
}
