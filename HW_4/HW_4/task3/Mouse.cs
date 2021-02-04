using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_4.task3;

namespace HW_4.task2
{
    class Mouse
    {
        public Mouse()
        {
            Cat.GetInstance().CatSaysMeow += () => Console.WriteLine("Mouse execute.");
        }
    }
}
