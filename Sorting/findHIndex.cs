//practise gfg link : https://www.geeksforgeeks.org/batch/gfg-160-problems/track/sorting-gfg-160/problem/find-h-index--165609
public class Solution
{
    public int HIndex(int[] citations)
    {
        int n = citations.Length;
        int[] freq = new int[n + 1];

        foreach (int c in citations)
        {
            if (c >= n)
                freq[n]++;
            else
                freq[c]++;
        }

        int idx = n, sum = freq[n];

        while (idx > 0 && sum < idx)
        {
            idx--;
            sum += freq[idx];
        }

        return idx;
    }
}
