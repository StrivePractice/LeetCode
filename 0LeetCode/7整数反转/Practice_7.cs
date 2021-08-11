using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7整数反转
{
    // 给你一个 32 位的有符号整数 x ，返回将 x 中的数字部分反转后的结果。
    //如果反转后整数超过 32 位的有符号整数的范围[−2147483648, 2147483647] ，就返回 0。
    //假设环境不允许存储 64 位整数（有符号或无符号）。
    public class Practice_7
    {
        public static void Main(string[] args)
        {
            //string str = "0123456789";
            //int x = int.Parse(str);
            //Console.WriteLine(x);
            Console.WriteLine(Reverse(-123));
            Console.ReadKey();
        }
        public static int Reverse(int x)
        {
            string str = x.ToString();
            string str_1 = "";
            if (x == 0)
            {
                return 0;
            }
            else if (x > 0)
            {
                for (int i = str.Length - 1 ; i >= 0 ; i--)
                {
                    str_1 += str[i];
                }
                if (int.TryParse(str_1, out x))
                {
                    return x;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                for (int i = str.Length - 1 ; i > 0 ; i--)
                {
                    str_1 += str[i];
                }
                if (int.TryParse(str_1, out x))
                {
                    return -x;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
