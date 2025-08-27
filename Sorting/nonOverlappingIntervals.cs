//practise gfg link : https://www.geeksforgeeks.org/batch/gfg-160-problems/track/sorting-gfg-160/problem/non-overlapping-intervals

class Solution
{
    public int minRemoval(int[][] intervals)
    {
        Array.Sort(intervals, (a, b) => a[1].CompareTo(b[1]));
        int count = 0, end = int.MinValue;
        for (int i = 0; i < intervals.Length; i++)
        {
            if ((end <= intervals[i][0]))
            {
                end = intervals[i][1];
            }
            else
            {
                count++;
            }
        }

        return count;
    }
}