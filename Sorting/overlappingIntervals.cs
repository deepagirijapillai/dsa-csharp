//practise gfg link : https://www.geeksforgeeks.org/batch/gfg-160-problems/track/sorting-gfg-160/problem/overlapping-intervals--170633
public class Solution
{
    public List<int[]> MergeOverlap(int[][] intervals)
    {
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        List<int[]> result = new List<int[]>();

        int index = 0;
        for (int i = 1; i < intervals.Length; i++)
        {
            if (intervals[index][1] >= intervals[i][0])
            {
                intervals[index][1] = Math.Max(intervals[index][1], intervals[i][1]);
            }
            else
            {
                index++;
                intervals[index] = intervals[i];
            }
        }

        for (int i = 0; i <= index; i++)
        {
            result.Add(intervals[i]);
        }

        return result;
    }
}
