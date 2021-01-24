using System;
using System.Collections;


namespace HW_1.task1_Collections
{
    public static class Stack
    {
        public static void PushStack()
        {
            System.Collections.Stack cars = new System.Collections.Stack();

            cars.Push("volkswagen");
            cars.Push("opel ");
            cars.Push("audi");
            cars.Push("BMW");
            cars.Push("nissan");

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }

            //  Выполнение через цикл for
            //  for (int i = 0; i < cars.Count; i++)
            //  Console.WriteLine(cars[i]);
        }

        public static void PopElement()
        {
            System.Collections.Stack cars = new System.Collections.Stack();
            cars.Push("volkswagen");
            cars.Push("opel ");
            cars.Push("audi");
            cars.Push("BMW");
            cars.Push("nissan");

            var popedCar = cars.Pop();

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }



        }
    }
}

