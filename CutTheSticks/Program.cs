using System;
using System.Collections.Generic;

namespace CutTheSticks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 3, 3, 2, 1 };

            List<int> sticksCut = new List<int>();
            int count = 0;
            int temp = 0;
            int little;
            int j = 0;

            while (count != arr.Length)
            {
                little = findLittle(arr);
                sticksCut.Add(arr.Length - count);
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] != 0)
                    {
                        temp = arr[i] - little;
                        arr[i] = temp;
                        if (temp == 0)
                        {
                            count++;
                        }
                    }

                }
                j++;
            }
            int[] sticksCutArr = new int[sticksCut.Count];
            for (int i = 0; i < sticksCut.Count; i++)
            {
                if (sticksCut[i] != 0)
                {
                    sticksCutArr[i] = sticksCut[i];
                    Console.WriteLine(sticksCut[i]);
                }
            }
        }

        //find little number 
        static int findLittle(int[] arr)
        {
            int little = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (little == 0)
                {
                    little = arr[i];
                }
                else if (arr[i] != 0 && little > arr[i])
                {
                    little = arr[i];
                }
            }
            return little;
        }


    }


}
