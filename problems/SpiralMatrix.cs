﻿using System;

namespace ProblemSolving
{
    public class SpiralMatrix
    {
        public int[] compute(int[,] array2D)
        {
            var rowCount = array2D.GetLength(0);
            var colCount = array2D.GetLength(1);

            var array = new int[rowCount * colCount];
            var rcount = rowCount - 1;
            var ccount = colCount - 1;

            var level = (int)Math.Ceiling((double)rowCount / 2);

            var index = 0;
            for (var lev = 0; lev <= level - 1; lev++)
            {
                for (var j = lev; j <= ccount - lev; j++)
                    array[index++] = array2D[lev, j];

                for (var k = lev + 1; k <= rcount - lev; k++)
                    array[index++] = array2D[k, ccount - lev];

                for (var l = ccount - 1 - lev; l >= lev; l--)
                    array[index++] = array2D[rcount - lev, l];

                for (var m = rcount - 1 - lev; m >= lev + 1; m--)
                    array[index++] = array2D[m, lev];
            }

            return array;
        }
    }
}

