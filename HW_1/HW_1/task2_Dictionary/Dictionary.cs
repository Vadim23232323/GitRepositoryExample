using System;
using System.Collections.Generic;
using System.Text;

namespace HW_1.task2_Dictionary
{
    public static class DictionaryExample
    {
        public static void ShowDictionary()
        {
            Dictionary<string, string> openWith = new Dictionary<string, string>();

            openWith.Add("volkswagen", "golf");
            openWith.Add("opel", "astra");
            openWith.Add("audi", "80");
            openWith.Add("BMW", "5");
            openWith.Add("nissan", "x - trail");

            foreach (var element in openWith)
            {
                Console.WriteLine($"Key: {element.Key} \tValue: {element.Value}");
            }
        }

        public static void DeleteDictionary()
        {
            Dictionary<int, string> openWith = new Dictionary<int, string>();

            openWith.Add(1, "golf");
            openWith.Add(2, "astra");
            openWith.Add(3, "80");
            openWith.Add(4, "5");
            openWith.Add(5, "x - trail");


            //удаляем элемент по ключу 
            openWith.Remove(3);
            foreach (var element in openWith)
            {
                Console.WriteLine($"Key: {element.Key} \tValue: {element.Value}");
            }
        }


    }
}
