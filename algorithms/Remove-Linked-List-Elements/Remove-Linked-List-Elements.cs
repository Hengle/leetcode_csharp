// Source : https://leetcode.com/problems/remove-linked-list-elements/
// Author : Jiadong Chen
// Date   : 2015-04-28
//Remove all elements from a linked list of integers that have value val.
//
//Example
//Given: 1 --> 2 --> 6 --> 3 --> 4 --> 5 --> 6, val = 6
//Return: 1 --> 2 --> 3 --> 4 --> 5

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode RemoveElements(ListNode head, int val) {
        ListNode ret = null;
       
        while(head != null)
        {
          if(head.val == val)
            head = head.next;
          else if(head.next != null && head.next.val == val)
          {
             head.next = head.next.next;
          }
          else if(ret == null)
            ret = head;
          else if(head != null)
            head = head.next;
        }
        return ret;
    }
}