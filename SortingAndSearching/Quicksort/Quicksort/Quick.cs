using System;
using System.Collections.Generic;
using System.Text;

namespace Quicksort
{
    public class Quick
    {
        public static void Sort<T>(T[] a) where T : IComparable<T>
        {
            Sort(a, 0, a.Length - 1);
        }

        private static void Sort<T>(T[] a, int lo, int hi) where T : IComparable<T>
        {
            if (lo >= hi)
            {
                return;
            }
            else
            {
                int p = Partition(a, lo, hi);
                Sort(a, lo, p - 1);
                Sort(a, p + 1, hi);
            }
        }

        private static int Partition<T>(T[] a, int lo, int hi) where T : IComparable<T>
        {
            if (lo >= hi)
            {
                return lo;
            }
            else
            {
                int i = lo;
                int j = hi + 1;
                while (true)
                {
                    while (IsLess(a[++i], a[lo]))
                    {                        
                        {
                            if (i == hi) break;
                        }
                    }
                    while (IsLess(a[lo], a[--j]))
                    {
                        {
                            if (j == lo) break;
                        }
                    }
                    if (i >= j) break;
                    Swap(a, i, j);
                }
                Swap(a, lo, j);
                return j;
            }
        }

        private static void Swap<T>(T[] a, int i, int j) where T : IComparable<T>
        {
            var temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }

        private static bool IsLess<T>(T t1, T t2) where T : IComparable<T>
        {
            var result = Comparer<T>.Default.Compare(t1, t2);
            if (result < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
