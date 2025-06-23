//practise gfg link : https://www.geeksforgeeks.org/batch/gfg-160-problems/track/string-gfg-160/problem/check-if-strings-are-rotations-of-each-other-or-not-1587115620
public class Solution
{
    public static bool AreRotations(string s1, string s2)
    {
        if (s1.Length != s2.Length)
            return false;

        int[] lps = new int[s2.Length];
        LPS(s2, lps);

        string combined = s1 + s1;
        int i = 0, j = 0;

        while (i < combined.Length)
        {
            if (combined[i] == s2[j])
            {
                i++;
                j++;

                if (j == s2.Length)
                    return true;
            }
            else
            {
                if (j == 0)
                {
                    i++;
                }
                else
                {
                    j = lps[j - 1];
                }
            }
        }

        return false;
    }

    private static void LPS(string s, int[] lps)
    {
        int len = 0, i = 1;
        lps[0] = 0;

        while (i < s.Length)
        {
            if (s[i] == s[len])
            {
                len++;
                lps[i] = len;
                i++;
            }
            else
            {
                if (len == 0)
                {
                    lps[i] = 0;
                    i++;
                }
                else
                {
                    len = lps[len - 1];
                }
            }
        }
    }
}