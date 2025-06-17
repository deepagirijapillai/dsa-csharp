//practise gfg link : https://www.geeksforgeeks.org/batch/gfg-160-problems/track/string-gfg-160/problem/search-pattern0205
public class Solution
{
    public List<int> Search(string pat, string txt)
    {
        int[] lps = LPS(pat);
        List<int> res = new List<int>();

        int i = 0, j = 0;
        while (i < txt.Length)
        {
            if (txt[i] == pat[j])
            {
                j++;
                i++;
                if (j == pat.Length)
                {
                    res.Add(i - j);
                    j = lps[j - 1];
                }
            }
            else
            {
                if (j != 0)
                {
                    j = lps[j - 1];
                }
                else
                {
                    i++;
                }
            }
        }

        return res;
    }

    private int[] LPS(string s)
    {
        int len = 0, n = s.Length;
        int[] lps = new int[n];
        int i = 1;
        lps[0] = 0;

        while (i < n)
        {
            if (s[i] == s[len])
            {
                len++;
                lps[i] = len;
                i++;
            }
            else
            {
                if (len != 0)
                {
                    len = lps[len - 1];
                }
                else
                {
                    lps[i] = 0;
                    i++;
                }
            }
        }

        return lps;
    }
}
