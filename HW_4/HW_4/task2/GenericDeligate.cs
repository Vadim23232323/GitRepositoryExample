using System;
using System.Collections.Generic;
using System.Text;

namespace HW_4.task2
{
    public class GenericDeligate
    {
        delegate T GenericDelegateT<T,R>(R r);


        public static void show()
        {

            GenericDelegateT< bool, string> genericDelegate_int = s => (false);
            Console.WriteLine($"task completed: {genericDelegate_int("")}");
        }
        
    }
}
