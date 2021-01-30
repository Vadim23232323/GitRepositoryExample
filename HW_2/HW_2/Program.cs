using System;
using System.Collections.Generic;
using HW_2.task1_UserCollection;
using HW_2.task2_GenericClass;

namespace HW_2
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                var exampleToRun = Examples.PlaceholderClassGeneric;

                switch (exampleToRun)
                {
                    // task 1 UserCollections
                    case Examples.ListUserCollection:
                        PUserCollection.UserGeneriList();
                        break;
                    // task 2 GenericClass
                    case Examples.PlaceholderClassGeneric:
                        PlaceholderClass<ValueType, string> genericplaceholder = new PlaceholderClass<ValueType, string>(100, "SUMMA");
                        genericplaceholder.ShowData();

                        break;
                }

                Console.Read();
            }

        }
    }
}
