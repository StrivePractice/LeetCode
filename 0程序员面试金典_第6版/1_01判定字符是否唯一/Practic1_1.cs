using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_01判定字符是否唯一
{
    //实现一个算法，确定一个字符串 s 的所有字符是否全都不同。
    public class Practic1_1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(IsUnique("abcdefghijklmnopqrstuvwxyz"));
            Console.ReadKey();
        }
        public static bool IsUnique(string astr)
        {
            HashSet<char> hastSet = new HashSet<char>();
            for (int i = 0 ; i < astr.Length ; i++)
            {
                if (!hastSet.Add(astr[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
