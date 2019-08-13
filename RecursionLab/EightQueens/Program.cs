using System;
using System.Collections.Generic;

namespace EightQueens
{
    class Program
    {
        static void Main(string[] args)
        {
            PutQueens(0);
        }
        public class EightQueens
        {

            public const int SIZE = 8;
            public static bool[,] chessboard = new bool[SIZE, SIZE];

            public static HashSet<int> attackedRows = new HashSet<int>();
            public static HashSet<int> attackedCollumns = new HashSet<int>();
            public static HashSet<int> attackedLeftDiagonals = new HashSet<int>();
            public static HashSet<int> attackedRightDiagonals = new HashSet<int>();

            public static int solutionsFound = 0;
        }

        static void PutQueens(int row)
        {
            if (row == EightQueens.SIZE)
            {
                PrintSolution();
            }
            else
            {
                for (int col = 0; col < EightQueens.SIZE; col++)
                {
                    if (CanPlaceQueen(row, col))
                    {
                        MarkAllAttackedPositions(row, col);
                        PutQueens(row + 1);
                        UnmarkAllAttackedPositions(row, col);
                    }
                }
            }
        }

        private static void UnmarkAllAttackedPositions(int row, int col)
        {
            EightQueens.attackedRows.Remove(row);
            EightQueens.attackedCollumns.Remove(col);
            EightQueens.attackedLeftDiagonals.Remove(col - row);
            EightQueens.attackedRightDiagonals.Remove(col + row);
            EightQueens.chessboard[row, col] = false;
        }

        private static void MarkAllAttackedPositions(int row, int col)
        {
            EightQueens.attackedRows.Add(row);
            EightQueens.attackedCollumns.Add(col);
            EightQueens.attackedLeftDiagonals.Add(col - row);
            EightQueens.attackedRightDiagonals.Add(col + row);
            EightQueens.chessboard[row, col] = true;
        }

        private static bool CanPlaceQueen(int row, int col)
        {
            var positionOccupied = EightQueens.attackedRows.Contains(row) ||
                EightQueens.attackedCollumns.Contains(col) ||
                EightQueens.attackedLeftDiagonals.Contains(col - row) ||
                EightQueens.attackedRightDiagonals.Contains(col + row);
            return !positionOccupied;

        }

        static void PrintSolution()
        {
            for (int row = 0; row < EightQueens.SIZE; row++)
            {
                for (int col = 0; col < EightQueens.SIZE; col++)
                {
                    if (EightQueens.chessboard[row,col])
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            EightQueens.solutionsFound++;
        }
    }
}
