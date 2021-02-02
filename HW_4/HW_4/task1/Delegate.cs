using System;
using System.Collections.Generic;
using System.Text;

namespace HW_4.task1
{
    public static class Delegate
    {
        delegate void MYCountDelegate();


            public static void count()
            {
                Console.WriteLine("Congratulations! You got discount for 25%");
            }


            public static void ShowDelegate()
            {
              
                MYCountDelegate countDelegate = () => count();
                
            countDelegate();
            }
        }
}
