// Source : https://leetcode.com/problems/two-sum/
// Author : Jiadong Chen
// Date   : 2015-04-25
//Given an array of integers, find two numbers such that they add up to a specific target number.
//
//The function twoSum should return indices of the two numbers such that they add up to the target, where index1 must be less than index2. Please note that your returned answers (both index1 and index2) are not zero-based.
//
//You may assume that each input would have exactly one solution.
//
//Input: numbers={2, 7, 11, 15}, target=9
//Output: index1=1, index2=2 

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        int temp = 0;
        for(int i = 0; i < nums.Length; i++)
        {
          temp = nums[i];
          if(dic.ContainsKey(target - temp))
              return new int[]{ dic[target - temp] + 1, i + 1};
          else if(!dic.ContainsKey(temp))
            dic.Add(temp, i);
        }
        throw new Exception("plz input right target");
    }
}

