﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2两数相加
{
    //2. 两数相加
    //给你两个 非空 的链表，表示两个非负的整数。它们每位数字都是按照 逆序 的方式存储的，并且每个节点只能存储 一位 数字。
    //请你将两个数相加，并以相同形式返回一个表示和的链表。
    //你可以假设除了数字 0 之外，这两个数都不会以 0 开头。
    public class Practice_2
    {
        public static void Main(string[] args)
        {
            //ListNode node_1 = new ListNode();
            //node_1.val = 3;
            //ListNode node_2 = new ListNode();
            //node_2.val = 3;
            //Console.WriteLine(addTwoNumbers(node_1, node_2));
            //Console.ReadKey();
        }
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            return new ListNode(0, null);
        }

    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
