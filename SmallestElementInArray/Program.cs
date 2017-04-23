﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndListAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int minValue = int.MaxValue;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] < minValue) minValue = myArray[i];
            }

            Console.WriteLine(minValue);
        }
    }
}