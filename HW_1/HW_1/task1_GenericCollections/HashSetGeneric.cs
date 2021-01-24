﻿using System;
using System.Collections.Generic;
using System.Collections;

namespace HW_1.task1_GenericCollections
{
    public static class HashSetExample
    {
        public static void ShowHashSet()
        {
            HashSet<short> codes = new HashSet<short>();
            codes.Add(1);
            codes.Add(2);
            codes.Add(3);

            foreach (var code in codes)
            {
                Console.WriteLine(code);
            }
        }

        public static void ContainsAndRemove()
        {
            HashSet<short> codes = new HashSet<short>();
            codes.Add(1);
            codes.Add(2);
            codes.Add(3);

            if (codes.Contains(2))
            {
                Console.WriteLine("Codes contains 2");
            }

            codes.Remove(2);

            foreach (var code in codes)
            {
                Console.WriteLine(code);
            }
        }

        public static void UnionSets()
        {
            HashSet<short> leftCodes = new HashSet<short>();
            leftCodes.Add(1);
            leftCodes.Add(2);
            leftCodes.Add(3);

            HashSet<short> rightCodes = new HashSet<short>();
            rightCodes.Add(1);
            rightCodes.Add(2);
            rightCodes.Add(4);

            //Операция обьединения
            leftCodes.UnionWith(rightCodes);

            foreach (var code in leftCodes)
            {
                Console.WriteLine(code);
            }
        }

        public static void ExceptSets()
        {
            HashSet<short> leftCodes = new HashSet<short>();
            leftCodes.Add(1);
            leftCodes.Add(2);
            leftCodes.Add(3);

            HashSet<short> rightCodes = new HashSet<short>();
            rightCodes.Add(1);
            rightCodes.Add(2);
            rightCodes.Add(4);

            //Операция разницы
            leftCodes.ExceptWith(rightCodes);

            foreach (var code in leftCodes)
            {
                Console.WriteLine(code);
            }
        }

        public static void IntersectSets()
        {
            HashSet<short> leftCodes = new HashSet<short>();
            leftCodes.Add(1);
            leftCodes.Add(2);
            leftCodes.Add(3);

            HashSet<short> rightCodes = new HashSet<short>();
            rightCodes.Add(1);
            rightCodes.Add(2);
            rightCodes.Add(4);

            //Операция пересечения
            leftCodes.IntersectWith(rightCodes);

            foreach (var code in leftCodes)
            {
                Console.WriteLine(code);
            }
        }
    }
}
