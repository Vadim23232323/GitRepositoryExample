using System;
using System.Collections;

namespace HW_1.task1_Collections
{
    public static class HashTableExample
    {
        public static void ShowHashTable()
        {
            Hashtable openWith = new Hashtable();

            openWith.Add("volkswagen", "golf");
            openWith.Add("opel", "astra");
            openWith.Add("audi", "80");
            openWith.Add("BMW", "5");
            openWith.Add("nissan", "x - trail");

            foreach (var value in openWith.Values)
            {
                Console.WriteLine(value);
            }
        }

        public static void PrintKeys()
        {
            Hashtable openWith = new Hashtable();

            openWith.Add("volkswagen", "golf");
            openWith.Add("opel", "astra");
            openWith.Add("audi", "80");
            openWith.Add("BMW", "5");
            openWith.Add("nissan", "x - trail");

            foreach (var key in openWith.Keys)
            {
                Console.WriteLine(key);
            }
        }

        public static void GetValueByKey()
        {
            Hashtable openWith = new Hashtable();

            openWith.Add("volkswagen", "golf");
            openWith.Add("opel", "astra");
            openWith.Add("audi", "80");
            openWith.Add("BMW", "5");
            openWith.Add("nissan", "x - trail");

            Console.WriteLine(openWith["audi"]);
        }

        public static void DuplicateKeys()
        {
            Hashtable openWith = new Hashtable();

            openWith.Add("volkswagen", "golf");
            openWith.Add("opel", "astra");
            openWith.Add("audi", "80");
            openWith.Add("BMW", "5");
            openWith.Add("nissan", "x - trail");

            try
            {
                openWith.Add("opel", "astra");
                Console.WriteLine("Insert successful");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void DuplicateValues()
        {
            Hashtable openWith = new Hashtable();

            openWith.Add("volkswagen", "golf");
            openWith.Add("opel", "astra");
            openWith.Add("audi", "80");
            openWith.Add("BMW", "5");
            openWith.Add("nissan", "x - trail");

            try
            {
                openWith.Add("peugeot", "406");
                Console.WriteLine("Insert successful");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void ConstructorInitialization()
        {
            Hashtable openWith = new Hashtable()
            {


                {"volkswagen", "golf"},
                {"opel", "astra"},
                {"audi", "80"},
                {"BMW", "5"},
                {"nissan", "x - trail"}
         
            };

            foreach (DictionaryEntry element in openWith)
            {
                Console.WriteLine($"Key:{element.Key}  \tValue:{element.Value}");
            }
        }
    }
}
