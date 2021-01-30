using System;
using System.Collections.Generic;
using System.Text;

namespace HW_2.task1_UserCollection
{
    public static class PUserCollection
    {
        public static void UserGeneriList()
        {
            UserCollection collection = new UserCollection();
            collection.MyList = new List<string>();
            collection.MyList.Add("Audi");
            collection.MyList.Add("opel");
            collection.MyList.Add("nissan");
            collection.MyList.Add("BMW");
            collection.MyList.Add("volkswagen");
            collection.MyList.Add("mazda");

            if (collection.MyList.Count > 5)
            {
                collection.MyList.Remove("opel");
            }
            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }

            Console.Read();
        }
    }
}


