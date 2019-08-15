using System;

namespace NestedLoopsToRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] vector = new int[n];

            Recursion(vector, 0);
        }

        private static void Recursion(int[] vector, int index)
        {
            if (index >= vector.Length)
            {
                Console.WriteLine(string.Join(" ", vector));
            }
            else
            {
                for (int i = 1; i <= vector.Length; i++)
                {
                    vector[index] = i;
                    Recursion(vector, index + 1);
                }

            }


        }
    }
}
