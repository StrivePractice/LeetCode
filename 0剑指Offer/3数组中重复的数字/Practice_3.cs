using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3数组中重复的数字
{
    //找出数组中重复的数字。
    //在一个长度为 n 的数组 nums 里的所有数字都在 0～n-1 的范围内。
    //数组中某些数字是重复的，但不知道有几个数字重复了，也不知道每个数字重复了几次。
    //请找出数组中任意一个重复的数字。

    public class Practice_3
    {
        public static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 3, 1, 0, 2, 5, 3 };
            int newNum = BinarySearch(nums,0);
            Console.WriteLine(newNum);
            Console.ReadKey();
        }

        public static int FindRepeatNumber(int[] nums)
        {
            int temp = -1;
            Array.Sort(nums);
            for (int i = 1 ; i < nums.Length ; i++)
            {
                temp = nums[i];
                if (Array.BinarySearch(nums, 0, i, temp) >= 0)
                {
                    return temp;
                }
            }
            return temp;
        }

        public static int BinarySearch(int[] nums, int target)
        {
            //int min = 0;
            //int max = nums.Length;
            //int mid = ( min + max ) / 2;
            //while (min < max)
            //{

            //}
            //return false;
            int[] arr = new int[nums.Length];
            for (int i = 0 ; i < nums.Length ; i++)
            {
                arr[nums[i]]++;
                if (arr[nums[i]] > 1) return nums[i];
            }
            return -1;

        }
    }
}
