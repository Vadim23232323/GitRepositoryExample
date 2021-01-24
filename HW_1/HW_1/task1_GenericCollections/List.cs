using System;
using System.Collections.Generic;
using System.Collections;

namespace HW_1.task1_GenericCollections
{
    public static class ListExample
    {
        public static void ShowList()
        {
            List<int> numbers = new List<int>();

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);
            
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            //  Выполнение через цикл for
            //for (int i = 0; i < numbers.Count; i++)
            // Console.WriteLine(numbers[i]);
        }

        public static void CompileError()
        {
            ArrayList numbers = new ArrayList();

            numbers.Add(1);
            numbers.Add("asd");

            try
            {
                Console.WriteLine((int)numbers[0] + (int)numbers[1]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
