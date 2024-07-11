public class Solution {
    public int LengthOfLastWord(string s) {
        s = s.Trim();

        // Kelimelere böl
        string[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return words[words.Length-1].Length;
    }
}