using System;
using HW_8.models;

namespace HW_8
{
    class Program
    {
        static void Main(string[] args)
        {
            var exampleToRun = ExamplesEnumeration.GetCarAuthor;

            switch (exampleToRun)
            {
                 case ExamplesEnumeration.GetCarAuthor:
                    GetData.GetDataCarAuthor();
                    break;
            }

            Console.Read();
        }
    }
}
