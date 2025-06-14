//practise gfg link : https://www.geeksforgeeks.org/batch/gfg-160-problems/track/arrays-gfg-160/problem/smallest-positive-missing-number-1587115621
public class Solution
{
    public int MissingNumber(int[] arr)
    {
        int n = arr.Length;
        bool[] present = new bool[n];

        foreach (int num in arr)
        {
            if (num > 0 && num <= n)
            {
                present[num - 1] = true;
            }
        }

        for (int i = 0; i < n; i++)
        {
            if (!present[i])
            {
                return i + 1;
            }
        }

        return n + 1;
    }
}
