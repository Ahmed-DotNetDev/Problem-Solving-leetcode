public class Solution {
    public bool IsPalindrome(int x) {
        int temp, modulus, sum = 0;
			temp = x;
			while (x>0)
			{
				modulus = x % 10;
				sum = (sum * 10) + modulus;
				x /= 10;
			}
			if (temp == sum)
			{
				return true;
			}
			else
			{
				return false;
			}
    }
}