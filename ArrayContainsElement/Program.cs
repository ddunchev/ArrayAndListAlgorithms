using System;
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
            int input = int.Parse(Console.ReadLine());

            string yesorNo = "no";

            for (int i = 0; i < myArray.Length; i++)
            {
                if (input == myArray[i]) yesorNo = "yes";
            }

            Console.WriteLine(yesorNo);
        }
    }
}