public class Solution {
    public int SubtractProductAndSum(int n) {
        int addRes = 0, mulRes=1,x=0;
		//1
		while (n>0)
		{
		    x = n %10;//1
			addRes += x;//6
			mulRes *= x;//6
			n /= 10;
		}

		return (mulRes - addRes);
    }
}