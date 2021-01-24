using System;
using System.Collections;

namespace HW_1.task1_Collections
{
    class QueueExample
    {
        public static void ShowQueue()
        {
            Queue cars = new Queue();

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

        public static void DequeueElement()
        {
            Queue cars = new Queue();

            cars.Enqueue("volkswagen");
            cars.Enqueue("opel ");
            cars.Enqueue("audi");
            cars.Enqueue("BMW");
            cars.Enqueue("nissan");

            var popedCar = cars.Dequeue();

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }

        public static void PeekElement()
        {
            Queue cars = new Queue();

            cars.Enqueue("volkswagen");
            cars.Enqueue("opel ");
            cars.Enqueue("audi");
            cars.Enqueue("BMW");
            cars.Enqueue("nissan");

            var popedCar = cars.Peek();

            foreach (var car in cars)
            {
                Console.WriteLine(popedCar);
            }
        }
    }
}
