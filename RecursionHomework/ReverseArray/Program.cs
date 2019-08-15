using System;
using System.Linq;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            ReverseArray(array, 0, array.Length - 1);
            Console.WriteLine(string.Join(" ", array));
        }

        public static void ReverseArray(int[] array, int lower, int upper)
        {
            for (int i = lower, j = upper; i < j; i++, j--)
            {
                var temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }

    }
}
