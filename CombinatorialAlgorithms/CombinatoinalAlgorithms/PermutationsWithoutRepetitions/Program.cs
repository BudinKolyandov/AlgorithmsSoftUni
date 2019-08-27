using System;

namespace PermutationsWithoutRepetitions
{
    class Program
    {
        static int[] elements;

        static void Permute(int index)//index is current cell to fill
        {
            if (index >= elements.Length)
            {
                Console.WriteLine(string.Join(' ', elements));
            }
            else
            {
                Permute(index + 1);
                for (int i = index + 1; i < elements.Length; i++)
                {
                    Swap(index, i);
                    Permute(index + 1);
                    Swap(index, i);
                }
            }
        }

        static void Swap(int first, int second)
        {
            var temp = elements[first];
            elements[first] = elements[second];
            elements[second] = temp;
        }


        static void Main(string[] args)
        {
            elements = new[] { 1, 2, 3, 4 };         
            Permute(0);
        }
    }
}
