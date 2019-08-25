using MergeSort;
using System;
using System.Linq;

namespace SortingAndSearching
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Mergesort<int>.Sort(input);

            Console.WriteLine(string.Join(' ', input));
        }
    }
}
