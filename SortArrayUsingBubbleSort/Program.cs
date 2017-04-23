using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayUsingBubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool swapped;

            do
            {
                swapped = false;

                for (int i = 0; i < myArray.Length - 1; i++)
                {
                    if (myArray[i] > myArray[i + 1])
                    {
                        Swap(myArray, i, i + 1);
                        swapped = true;
                    }
                }
            } while (swapped);

            Console.WriteLine(String.Join(" ", myArray));
        }

        private static void Swap(int[] array, int i, int j)
        {
            int temp = 0;
            temp = array[j];
            array[j] = array[i];
            array[i] = temp;
        }
    }
}
