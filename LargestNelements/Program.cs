using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LergestNelements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = Console.ReadLine().Split().Select(int.Parse).ToList();
            var input = int.Parse(Console.ReadLine());

            var orderedList = myList.OrderByDescending(x => x);

            foreach (var item in orderedList)
            {
                Console.Write(item + " ");
                input--;
                if (input == 0) break;
            }
        }
    }
}
