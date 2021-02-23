using System;
using System.Collections.Generic;
using System.Text;
using HW_9.models;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;


namespace HW_9
{
   public static class ExamplesRunner<T>
    {

        public static void ShowMethodsAttributes(T instance)
        {
            var methods = instance.GetType().GetMethods();

            foreach (var method in methods)
                foreach (var attributeData in method.CustomAttributes)
                    Console.WriteLine(attributeData);
        }

        public static void ShowAllAttributes(T instance)
        {
            var members = instance.GetType().GetMembers();

            foreach (var member in members)
                foreach (var attributeData in member.CustomAttributes)
                    Console.WriteLine(attributeData);
        }
    }
}
