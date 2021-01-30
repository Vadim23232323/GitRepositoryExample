using System;
using System.Collections.Generic;
using System.Text;

namespace HW_2.task2_GenericClass
{
  
        public class PlaceholderClass<T, R>
            {
        private T id;
        private R key;

        public PlaceholderClass(T id, R key)
        {
            this.id = id;
            this.key = key;
        }

        public void ShowData()
        {
            Console.WriteLine($"id: Type - {typeof(T).ToString()}, Value - {id}");
            Console.WriteLine($"key: Type - {typeof(R).ToString()}, Value - {key}");
        }

        public (T, R) GetData()
        {
            return (id, key);
        }
    }
    
}

