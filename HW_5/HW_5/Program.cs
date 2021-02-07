using System;
using HW_5;
using HW_5.task2;

namespace HW_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var exampleToRun = Examples.linqjoin;

            switch (exampleToRun)
            {
                case Examples.linqjoin:
                    JoinClause.ShowJoinWithQuerySyntax();
                    break;
            }
        }
    }
}
