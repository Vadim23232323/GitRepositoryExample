using System;
using System.Collections.Generic;
using System.Text;
using HW_4.task2;

namespace HW_4.task2
{
    class Dog
    {
        public Dog()
        {
            Cat.GetInstance().CatSaysMeow += () => Console.WriteLine("the dog gave a voice");
        }
    }
}
