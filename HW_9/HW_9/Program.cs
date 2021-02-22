using System;
using HW_9.models;
using HW_9.Json;
using HW_9.Attribute;


namespace HW_9
{
    class Program
    {
        static void Main(string[] args)
        {
            var exampleToRun = ExamplesEnumeration.ShowMethodsAttributes;

            switch (exampleToRun)
            {
                case ExamplesEnumeration.ShowMethodsAttributes:
                    ExamplesRunner<Car>.ShowMethodsAttributes(new Car());
                    break;
                case ExamplesEnumeration.ShowAllAttributes:
                    ExamplesRunner<Car>.ShowAllAttributes(new Car());
                    break;
                case ExamplesEnumeration.ShowJsonSerialization:
                    SimpleJsonSerizalization.ShowJsonSerialization();
                    break;
                case ExamplesEnumeration.ShowJsonDesirealization:
                    JsonDesirealization.ShowJsonDesirealization();
                    break;
            }
            Console.Read();
        }
    }
}
