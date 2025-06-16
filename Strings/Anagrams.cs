//practise gfg link : https://www.geeksforgeeks.org/batch/gfg-160-problems/track/string-gfg-160/problem/anagram-1587115620
public class Solution
{
    public bool AreAnagrams(string s1, string s2)
    {
        if (s1.Length != s2.Length)
            return false;

        int[] freq = new int[26];

        foreach (char c in s1)
            freq[c - 'a']++;

        foreach (char c in s2)
            freq[c - 'a']--;

        foreach (int count in freq)
        {
            if (count != 0)
                return false;
        }

        return true;
    }
}
