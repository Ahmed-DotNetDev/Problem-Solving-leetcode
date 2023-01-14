public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        int counter=0;
			int size = operations.Length;
			for (int i = 0; i < size; i++)
			{
				if (operations[i]== "--X" || operations[i] == "X--")
				{
					counter--;
				}
				if(operations[i] == "++X" || operations[i] == "X++")
				{
					counter++;
				}
			}
			return counter;
    }
}