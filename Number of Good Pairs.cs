public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        int counter=0;
        int size=nums.Length;
       for(int i=0;i<size;i++)
       {
           for(int j=0;j<size;j++){
               if(nums[i]==nums[j] && i<j)
               {
                   counter++;
               }
           }
       }
       
       return counter;
    }
}