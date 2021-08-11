using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5替换空格
{
    //请实现一个函数，把字符串 s 中的每个空格替换成"%20"。
    public class Practice_5
    {
        public static void Main(string[] args)
        {
            string s = "We are happy.";
            Console.WriteLine(ReplaceSpace_1(s));
            Console.ReadKey();
        }
        public static string ReplaceSpace(string s)
        {
            string str = s.Replace(" ", "%20");
            return str;
        }
        public static string ReplaceSpace_1(string s)
        {
            string str = "";
            foreach (var item in s)
            {
                if (item == ' ')
                {
                    str += "%20";
                }
                else
                {
                    str += item;
                }
            }
            return str;
        }
    }
}
