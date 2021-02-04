using System;
using System.Collections.Generic;
using System.Text;
using HW_4.task2;

namespace HW_4.task2
{
    class Human
    {
        public Human()
        {
            Cat.GetInstance().CatSaysMeow += () => Console.WriteLine("Human feeds the kitten.");
        }
    }
}
