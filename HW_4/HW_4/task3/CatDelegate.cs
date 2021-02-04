using System;
using System.Collections.Generic;
using System.Text;
using HW_4.task2;

namespace HW_4.task3
{
    public static class CatDelegate
    {
        public delegate void CatMeowsDelegate();

        public static void catdelegates()
        {

            Cat littleKitty = Cat.GetInstance();

            Dog dog = new Dog();
            Human human = new Human();
            Mouse mouse = new Mouse();
            Mouse oneMoreMouse = new Mouse();

            littleKitty.Meow();
        }

    }
}
