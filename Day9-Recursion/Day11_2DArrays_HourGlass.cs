using System;
using System.Collections.Generic;
using System.Linq;

namespace Day9_Recursion
{
    //URL https://www.hackerrank.com/challenges/30-2d-arrays/problem?h_r=next-challenge&h_v=zen
    public class Day11_2DArrays_HourGlass
    {
        public static void GetHourGlass()
        {
            int[,] arr = new int[6,6];

            for (int i = 0; i < 6; i++)
            {
                var input = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
                for (int j = 0; j < 6; j++)
                {
                    arr[i, j] = input[j];
                }
            }
            List<int> sums = new List<int>();
            for (int fromRow = 0; fromRow < arr.GetLength(0) - 2; fromRow++)
            {
                int toRow = fromRow + 2;
                for (int fromColumn = 0; fromColumn < arr.GetLength(1) - 2; fromColumn++)
                {
                    int toColumn = fromColumn + 2;

                    var hourGlass = arr.SliceArray(fromRow, toRow, fromColumn, toColumn);
                    int[] flatHourGlass = hourGlass.Cast<int>().ToArray();
                    var hourGlassSum = flatHourGlass.Sum() - (flatHourGlass[3] + flatHourGlass[5]);
                    sums.Add(hourGlassSum);
                }
            }

            Console.WriteLine(sums.OrderByDescending(i => i).First());
        }
    }

    public static class SliceExtenssion
    {
        /// <summary>
        /// from and to parameters are zero based, (to and from are inclusive indexes)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="fromRow">0 based row index</param>
        /// <param name="toRow">0 based row index</param>
        /// <param name="fromColumn">0 based column index</param>
        /// <param name="toColumn">0 based column index</param>
        /// <returns></returns>
        public static T[,] SliceArray<T>(this T[,] array, int fromRow, int toRow, int fromColumn, int toColumn)
        {
            var numberOfRows = array.GetLength(0);
            var numberOfColumns = array.GetLength(1);

            if (fromRow > numberOfRows)
                throw new IndexOutOfRangeException();
            if (toRow > numberOfRows)
                throw new IndexOutOfRangeException();
            if (fromRow > toRow)
                throw new IndexOutOfRangeException();

            if (fromColumn > numberOfColumns)
                throw new IndexOutOfRangeException();
            if (toColumn > numberOfColumns)
                throw new IndexOutOfRangeException();
            if (fromColumn > toColumn)
                throw new IndexOutOfRangeException();

            int newColumnDimension = (toColumn - fromColumn) + 1;
            int newRowDimension = (toRow - fromRow) + 1;

            T[,] slicedArray = new T[newRowDimension, newColumnDimension];
            int slicedArrayRowIndex = 0;
            for (int row = fromRow; row <= toRow; row++)
            {
                var slicedArrayColumnIndex = 0;
                for (int column = fromColumn; column <= toColumn; column++)
                {
                    slicedArray[slicedArrayRowIndex, slicedArrayColumnIndex] = array[row, column];
                    slicedArrayColumnIndex++;
                }
                slicedArrayRowIndex++;
            }

            return slicedArray;
        }
    }
}