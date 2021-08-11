using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1斐波那契数列
{
    //写一个函数，输入 n ，求斐波那契（Fibonacci）数列的第 n 项（即 F(N)）。斐波那契数列的定义如下：
    //F(0) = 0,   F(1) = 1
    //F(N) = F(N - 1) + F(N - 2), 其中 N > 1.
    //斐波那契数列由 0 和 1 开始，之后的斐波那契数就是由之前的两数相加而得出。
    //答案需要取模 1e9+7（1000000007），如计算初始结果为：1000000008，请返回 1。
    public class Practice_10_1
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine(Fib(6));
            //Console.WriteLine(Fib_1(6));
            //Console.WriteLine(Fib_2(6));
            //Console.WriteLine(Fib_3(6));
            //Console.WriteLine(Fib_4(55));
            //Console.WriteLine(Fib_5(6));
            int x = 12;
            int y = 1;
            while (x != 0)
            {
                x -= Fib_5(y);
                y++;
            }
            Console.WriteLine(y - 1);
            Console.ReadKey();
        }
        public static int Fib(int n)//迭代
        {
            if (n <= 1)
            {
                return n;
            }
            int a = 1, b = 0;
            for (int i = 1 ; i < n ; i++)
            {
                a = a + b;
                b = a - b;
                a %= 1000000007;
            }
            return a;
        }
        public static int Fib_1(int n)//动态规划
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                int[] db = { 0, 1 };
                for (int i = 2 ; i <= n ; i++)
                {
                    int tmp = ( db[0] + db[1] ) % 1000000007;
                    db[0] = db[1];
                    db[1] = tmp;
                }
                return db[1];
            }
        }
        public static int[] memo = new int[101];
        public static int Fib_2(int n)//递归
        {
            if (n <= 1)
            {
                return n;
            }
            if (memo[n] != 0)
            {
                return memo[n];
            }
            memo[n] = ( Fib_2(n - 1) + Fib_2(n - 2) ) % 1000000007;
            return memo[n];
        }
        public static int Fib_3(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            int f1 = 0, f2 = 1;
            int temp;
            for (int i = 2 ; i <= n ; i++)
            {
                temp = ( f1 + f2 ) % 1000000007;
                f1 = f2;
                f2 = temp;
            }
            return f2;
        }

        public static int Fib_4(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            int f1 = 0, f2 = 1;
            int temp;
            for (int i = 2 ; i <= n ; i++)
            {
                temp = f1 + f2;
                f1 = f2;
                f2 = temp;
            }
            return f2;
        }
        public static int Fib_5(int n)
        {
            if (n <= 2)
                return 1;
            else
                return Fib_5(n - 1) + Fib_5(n - 2);
        }
    }
}
