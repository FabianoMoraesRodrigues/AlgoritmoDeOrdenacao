﻿using System;

namespace AlgoritmoDeOrdenacao.Class
{
    class ShellSort: Display
    {
        public void PerformShellSort(int[] arr)
        {
            shellSort(arr, arr.Length);
            DisplayArray("ShellSort",arr);
        }
        static void shellSort(int[] arr, int array_size)
        {
            int i, j, inc, temp;
            inc = 3;
            while (inc > 0)
            {
                for (i = 0; i < array_size; i++)
                {
                    j = i;
                    temp = arr[i];
                    while ((j >= inc) && (arr[j - inc] > temp))
                    {
                        arr[j] = arr[j - inc];
                        j = j - inc;
                    }
                    arr[j] = temp;
                }
                if (inc / 2 != 0)
                    inc = inc / 2;
                else if (inc == 1)
                    inc = 0;
                else
                    inc = 1;
            }
        }
    }
}
