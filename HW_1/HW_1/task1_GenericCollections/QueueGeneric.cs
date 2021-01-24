using System;
using System.Collections.Generic;
using System.Collections;

namespace HW_1.task1_GenericCollections
{
    public static class GenericQueueExample
    {
        public static void ShowGenericQueue()
        {
            Queue<String> cars = new Queue<string>();

            cars.Enqueue("volkswagen");
            cars.Enqueue("opel ");
            cars.Enqueue("audi");
            cars.Enqueue("BMW");
            cars.Enqueue("nissan");

            foreach (var car in cars)
            {
                Console.WriteLine(car); 
            }
        }

        public static void CompileError()
        {
            Queue cars = new Queue();

            cars.Enqueue("volkswagen");
            cars.Enqueue("opel ");
            cars.Enqueue("audi");
            cars.Enqueue("BMW");
            cars.Enqueue("nissan");
            cars.Enqueue(new object());

            try
            {
                foreach (var car in cars)
                {
                    double tmpCar = (double)car;
                    Console.WriteLine(tmpCar);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
