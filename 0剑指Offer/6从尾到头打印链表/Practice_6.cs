using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6从尾到头打印链表
{
    //输入一个链表的头节点，从尾到头反过来返回每个节点的值（用数组返回）。
    public class Practice_6
    {
        public static void Main(string[] args)
        {
            Console.ReadKey();
        }
        public static int[] ReversePrint(ListNode head)
        {
            ListNode node = head;
            int count = 0;
            while (node != null)
            {
                ++count;
                node = node.next;
            }
            int[] nums = new int[count];
            node = head;
            for (int i = count - 1 ; i >= 0 ; --i)
            {
                nums[i] = node.val;
                node = node.next;
            }
            return nums;
        }


    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
