using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15二进制中1的个数
{
    public class Practice_15
    {
        public static void Main(string[] args)
        {
        }

        /// <summary>
        /// 循环检查二进制位
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int HammingWeight(uint n)
        {
            int ret = 0;
            for (int i = 0 ; i < 32 ; i++)
            {
                if (( n & ( 1 << i ) ) != 0)
                {
                    ret++;
                }
            }
            return ret;
        }
        /// <summary>
        /// 位运算优化
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int HammingWeight1(uint n)
        {
            int ret = 0;
            while (n != 0)
            {
                n &= n - 1;
                ret++;
            }
            return ret;
        }
    }
}
