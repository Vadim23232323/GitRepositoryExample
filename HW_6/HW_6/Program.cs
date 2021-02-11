using System;
using HW_6.task1;
using HW_6.task2;
using HW_6.task3;

namespace HW_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var exampleToRun = Examples.linqjoinleft;

            switch (exampleToRun)
            {
                case Examples.linqAnonymousTypes:
                    AnonymousTypes.ShowAnonymousTypes();
                    break;
                case Examples.linqjoinleft:
                    leftjoin.ShowLeftJoin();
                    break;
                case Examples.showAdoNet:
                    AdoNet.AdonetShow();
                    break;
            }
        }
    }
}
