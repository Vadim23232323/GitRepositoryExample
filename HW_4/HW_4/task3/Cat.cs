using System;
using System.Collections.Generic;
using System.Text;
using HW_4.task3;

namespace HW_4.task2
{
    class Cat
    {
        private static Cat CatInstance;
        //Блокируем 
        private Cat()
        { }
        public static Cat GetInstance()
        {
            return CatInstance ?? (CatInstance = new Cat());
        }

        public event CatDelegate.CatMeowsDelegate CatSaysMeow;

        public void Meow()
        {
            Console.WriteLine("kot myaukayet");
            CatSaysMeow?.Invoke();
        }
    }
}
