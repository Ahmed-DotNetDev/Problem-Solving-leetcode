public class Solution {
    public int[] RunningSum(int[] nums)
	{
        int size=nums.Length;
		for (int i = 1; i <size; i++)
		{
			//  1          0 =1
			//  1          1 =2
			//  1          2 =3
			//  1          3 =4
			//  1          4 =5
			nums[i] += nums[i - 1];
		}
		return nums;
	}
}