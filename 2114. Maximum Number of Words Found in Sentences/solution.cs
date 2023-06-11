public class Solution 
{
    public int MostWordsFound(string[] sentences) 
    {
        int maxLen = 0;
        for (int i = 0; i < sentences.Length; i++)
        {
            string[] words = sentences[i].Split(" ");
            if (words.Length > maxLen)
            {
                maxLen = words.Length;
            }
        }

        return maxLen;
    }
}