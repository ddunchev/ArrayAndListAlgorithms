using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayInPlace
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int length = array.Length;

            int temp = 0;

            for (int i = 0; i < length / 2; i++)
            {
                temp = array[length - 1 - i];
                array[length - 1 - i] = array[i];
                array[i] = temp;
            }

            Console.WriteLine(String.Join(" ", array));
        }
    }
}
