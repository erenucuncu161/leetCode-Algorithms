public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        string yeniString = null;


        if (word1.Length > word2.Length)
        {
            for (int i = 0; i < word2.Length; i++)
            {
                ; yeniString += word1[i].ToString() + word2[i].ToString();
            }
            yeniString += word1.Substring(word2.Length);
        }

        else if (word1.Length < word2.Length)
        {
            for (int i = 0; i < word1.Length; i++)
            {
                yeniString += word1[i].ToString() + word2[i].ToString();
            }
            yeniString += word2.Substring(word1.Length);
        }
        else
        {
            for (int i = 0; i < word1.Length; i++)
            {
                yeniString += word1[i].ToString() + word2[i].ToString();
            }
        }

        return yeniString;
    }
}
