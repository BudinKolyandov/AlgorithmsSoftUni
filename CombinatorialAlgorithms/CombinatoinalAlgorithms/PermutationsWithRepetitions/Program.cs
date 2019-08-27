using System;
using System.Collections.Generic;

namespace PermutationsWithRepetitions
{
    class Program
    {
        static int[] arr;

        static void Permute(int[] arr, int start, int end)
        {
            Console.WriteLine(string.Join(' ', arr));
            for (int left = end; left >= start; left--)
            {
                for (int right = left + 1 ; right <= end; right++)
                {
                    if (arr[left] != arr[right] && arr[left] < arr.Length - 1  && arr[right] < arr.Length - 1)
                    {
                        Swap(arr[left], arr[right]);
                        Permute(arr, left + 1, end);
                    }
                    var firstElement = arr[left];
                    for (int i = left; i < end; i++)
                    {
                        arr[i] = arr[i + 1];
                    }
                    arr[end] = firstElement;
                }
            }
        }

        static void Swap(int first, int second)
        {
            var temp = arr[first];
            arr[first] = arr[second];
            arr[second] = temp;
        }


        static void Main(string[] args)
        {
            arr = new[] { 1, 3, 5, 2, 3, };
            Array.Sort(arr);
            Permute(arr, 0, arr.Length - 1);
        }
    }
}
