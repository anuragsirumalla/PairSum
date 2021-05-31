using System;
using System.Collections.Generic;

namespace PairSum
{
    public class Program
    {
        public static bool PairSum(List<int> list, int sum)
        {
            int rotate = -1;
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] > list[i + 1])
                {
                    rotate = i + 1;
                }
            }
            int presentOnLeft = rotate - 1;
            int presentOnRight = rotate;
            int totalIterations = Math.Min(presentOnLeft, presentOnRight);
            for (int i = 1; i <= totalIterations; i++)
            {
                if (list[presentOnRight] + list[presentOnLeft] == sum)
                {
                    return true;
                }
                else if (list[presentOnRight] + list[presentOnLeft] < sum)
                {
                    presentOnRight++;
                }
                else if (list[presentOnRight] + list[presentOnLeft] > sum)
                {
                    presentOnLeft--;
                }
            }
            return false;
        }

        public static bool PairSumBruteForce(List<int> list, int sum)
        {
            int rotate = -1;
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] > list[i + 1])
                {
                    rotate = i + 1;
                }
            }
            for (int i = rotate; i >= 0; i--)
            {
                for (int j = rotate; j < list.Count; j++)
                {
                    if (list[i] + list[j] == sum)
                    {
                        Console.WriteLine(list[i] + " + " + list[j] + " = " + sum);
                        return true;
                    }
                }
            }
            return false;
        }

        static public void Main()
        {
            //Code
            var arr = new List<int>() { 11, 25, 36, 47, 5, 6, 7 };
            Console.WriteLine(PairSum(arr, 51));
        }
    }
}