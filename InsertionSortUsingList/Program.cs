using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayUsingInsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int firstUnsorted = 0; firstUnsorted < array.Length - 1; firstUnsorted++)
            {
                var index = firstUnsorted + 1;
                while (index > 0)
                {
                    if (array[index - 1] > array[index])
                        Swap(array, index, index - 1); // todo: write Swap() method
                    index--;
                }
            }

            Console.WriteLine(String.Join(" ", array));
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
