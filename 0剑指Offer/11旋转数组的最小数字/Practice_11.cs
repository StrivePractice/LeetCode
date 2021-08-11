using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11旋转数组的最小数字
{
    //把一个数组最开始的若干个元素搬到数组的末尾，我们称之为数组的旋转。输入一个递增排序的数组的一个旋转，
    //输出旋转数组的最小元素。例如，数组[3, 4, 5, 1, 2] 为[1, 2, 3, 4, 5] 的一个旋转，该数组的最小值为1。  
    public class Practice_11
    {
        public static void Main(string[] args)
        {
        }
        public static int MinArray(int[] numbers)
        {
            for (int i = 0 ; i < numbers.Length - 1 ; i++)
            {
                if (numbers[i + 1] < numbers[i]) return numbers[i + 1];
            }
            return numbers[0];
        }

        public static int[] BubbleSort(int[] arr)
        {
            if (arr == null || arr.Length < 2) return arr;
            int n = arr.Length;
            for (int i = 0 ; i < n ; i++)
            {
                bool flag = true;
                for (int j = 0 ; j < n - i - 1 ; j++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        flag = false;
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }
                if (flag)
                    break;
            }
            return arr;
        }
    }
}
