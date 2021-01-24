using System;
using System.Collections;

namespace HW_1.task1_Collections
{
    public static class ArrayListExample
    {
        public static void ShowArrayList()
        {
            ArrayList cars = new ArrayList();
            cars.Add("volkswagen");
            cars.Add("opel ");
            cars.Add("audi");
            cars.Add("BMW");
            cars.Add("nissan");

            foreach (var car in cars)
            { 
                 Console.WriteLine(car);
            }

            //  Выполнение через цикл for
            //  for (int i = 0; i < cars.Count; i++)
            //  Console.WriteLine(cars[i]);
        }

        public static void ShowArrayListTo()
        {
            ArrayList cars = new ArrayList()
            {
                "volkswagen",
                "opel ",
                "audi",
                "BMW",
                "nissan",
        };

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }

            //  Выполнение через цикл for
            //  for (int i = 0; i < cars.Count; i++)
            //  Console.WriteLine(cars[i]);
        }
    }
}
