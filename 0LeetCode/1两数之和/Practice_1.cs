using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1两数之和
{
    //1. 两数之和
    //给定一个整数数组 nums 和一个整数目标值 target，
    //请你在该数组中找出 和为目标值 target 的那 两个 整数，并返回它们的数组下标。
    //你可以假设每种输入只会对应一个答案。但是，数组中同一个元素在答案里不能重复出现。
    //你可以按任意顺序返回答案。
    public class Practice_1
    {
        public static void Main(string[] args)
        {
            int[] arrs = new int[4] { 3, 7, 2, 4 };
            int[] endArrs = TwoSum_1(arrs, 6);
            foreach (int item in endArrs)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] arr = new int[2];
            int offset = 0;
            for (int i = 0 ; i < nums.Length - 1 ; i++)
            {
                offset = target - nums[i];
                for (int j = i + 1 ; j < nums.Length ; j++)
                {
                    if (nums[j] == offset)
                    {
                        arr[0] = i;
                        arr[1] = j;
                        return arr;
                    }
                }
            }
            return arr;
        }
        public static int[] TwoSum_1(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0 ; i < nums.Length ; i++)
            {
                if (dic.ContainsKey(nums[i]))
                {
                    return new int[] { dic[nums[i]], i };
                }
                dic.Add(target - nums[i], i);
            }
            return null;
        }
    }
}
