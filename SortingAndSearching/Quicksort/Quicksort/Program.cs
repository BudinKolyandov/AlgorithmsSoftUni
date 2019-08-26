using System;
using System.Linq;

namespace Quicksort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();


            Quick.Sort<int>(arr);

            Console.WriteLine(string.Join(' ', arr));
        }
    }
}
