// Source : https://leetcode.com/problems/add-two-numbers/
// Author : Jiadong Chen
// Date   : 2015-04-27
//You are given two linked lists representing two non-negative numbers. The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.
//
//Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
//Output: 7 -> 0 -> 8
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
    {
        ListNode ret = null;
        ListNode temp = null;
        int sum = 0;
        int carry = 0;
        int x = 0;
        int y = 0;
        int cur = 0;
        while(l1 != null || l2 != null)
        {
          //get val
          x = y = 0;
          if(l1 != null)
          {
              x = l1.val;
              l1 = l1.next;
          }
          if(l2 != null)
          {
              y = l2.val;
              l2 = l2.next;
          }
          //calculate val
          sum = carry + x + y;
          carry = sum / 10;
          cur = sum % 10;
          //new next node
          ListNode node = new ListNode(cur);
    
          if(temp == null)
          {
              temp = node;
              ret = temp;
          }
          else
          {
              temp.next = node;
              temp = temp.next;
          }
        }
    
        if(carry > 0)
        {
          ListNode node2 = new ListNode(carry);
          temp.next = node2;
        }
    
        return ret;
    }
}

