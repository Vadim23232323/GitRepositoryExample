using System;
using System.Collections.Generic;
using System.Collections;

namespace HW_1.task1_GenericCollections
{
    public static class GenericStackExample
    {
        public static void ShowGenericStack()
        {
            Stack<string> cars = new Stack<string>();

           
            cars.Push("volkswagen");
            cars.Push("opel");
            cars.Push("audi");
            cars.Push("BMW");
            cars.Push("nissan");


            foreach (var car in cars)
            {
                Console.WriteLine(car); 
            }
        }

        public static void CompileError()
        {
            Stack cars = new Stack();

            cars.Push("volkswagen");
            cars.Push("opel");
            cars.Push("audi");
            cars.Push("BMW");
            cars.Push("nissan");

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
