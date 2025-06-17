//practise gfg link : https://www.geeksforgeeks.org/batch/gfg-160-problems/track/string-gfg-160/problem/non-repeating-character-1587115620
public class Solution
{
    public char NonRepeatingChar(string s)
    {
        int[] freq = new int[26];

        foreach (char c in s)
        {
            freq[c - 'a']++;
        }

        foreach (char c in s)
        {
            if (freq[c - 'a'] == 1)
            {
                return c;
            }
        }

        return '$';
    }
}
