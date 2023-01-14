public class Solution {
    public int MostWordsFound(string[] sentences) {
     	int counter = 0, temp = 0, size = sentences.Length;

			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < sentences[i].Length; j++)
				{
					if (sentences[i][j] == ' ')
					{
						counter++;
					}
				}
				if (temp < counter)
				{
					temp = counter;
				}
				counter = 0;
			}
			return temp+1;   
    }
}