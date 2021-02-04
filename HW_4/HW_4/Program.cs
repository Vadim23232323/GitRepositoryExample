using System;
using HW_4.task1;
using Delegate = HW_4.task1.Delegate;
using HW_4.task2;
using HW_4.task3;

namespace HW_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var exampleToRun = ExamplesEnumeration.DelegateCat;

            switch (exampleToRun)
            {
                case ExamplesEnumeration.DelegatesBasic:
                    Delegate.ShowDelegate();
                    break;
                case ExamplesEnumeration.DeligateGeneric:
                    GenericDeligate.show();
                    break;
                case ExamplesEnumeration.DelegateCat:
                    CatDelegate.catdelegates();
                    break;

            }

            Console.Read();
        }
    }
}
