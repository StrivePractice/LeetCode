using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9用两个栈实现队列
{
    //用两个栈实现一个队列。队列的声明如下，请实现它的两个函数 appendTail 和 deleteHead ，
    //分别完成在队列尾部插入整数和在队列头部删除整数的功能。(若队列中没有元素，deleteHead 操作返回 -1 )
    public class Practice_9
    {
        public static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            CQueue cq = new CQueue();
            cq.AppendTail(1);
            Console.WriteLine(cq.DeleteHead());
            Console.ReadKey();
        }
    }
    public class CQueue
    {
        Stack<int> stack1 = new Stack<int>();
        Stack<int> stack2 = new Stack<int>();

        public CQueue()
        {

        }

        public void AppendTail(int value)
        {
            stack1.Push(value);
        }

        public int DeleteHead()
        {
            int temp;
            if (stack1.Count == 0)
            {
                return -1;
            }
            stack2.Clear();
            foreach (var item in stack1)
            {
                stack2.Push(item);
            }
            temp = stack2.Pop();
            stack1.Clear();
            foreach (var item in stack2)
            {
                stack1.Push(item);
            }
            return temp;
        }
        public int DeleteHead_1()
        {
            if (stack2.Count != 0)
            {
                return stack2.Pop();
            }
            if (stack1.Count == 0) return -1;
            while (stack1.Count != 0)
            {
                stack2.Push(stack1.Pop());
            }
            return stack2.Pop();
        }
    }
}
