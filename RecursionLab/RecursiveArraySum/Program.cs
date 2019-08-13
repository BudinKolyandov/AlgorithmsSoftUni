﻿using System;
using System.Linq;

namespace RecursiveArraySum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(Sum(input, 0));


        }
        private static int Sum(int[] array, int index)
        {
            if (index == array.Length - 1)
            {
                return array[index];
            }
            return array[index] + Sum(array, index + 1);
        }
    }
}