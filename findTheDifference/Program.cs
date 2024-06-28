using System.Collections;

public class Solution
{
    public char FindTheDifference(string s, string t)
    {
        ArrayList harfler = new ArrayList();
        for (int i = 0; i < t.Length; i++)
        {
            harfler.Add(t[i]);
        }
        for (int j = 0; j < s.Length; j++)
        {
            harfler.Remove(s[j]);




        }


        return (char)harfler[0];
    }
}