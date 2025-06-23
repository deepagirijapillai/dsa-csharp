//practise gfg link : https://www.geeksforgeeks.org/batch/gfg-160-problems/track/sorting-gfg-160/problem/insert-interval-1666733333
public class Solution
{
    public static List<int[]> InsertInterval(int[][] intervals, int[] newInterval)
    {
        List<int[]> result = new List<int[]>();
        int i = 0;
        int n = intervals.Length;

        while (i < n && intervals[i][1] < newInterval[0])
        {
            result.Add(intervals[i]);
            i++;
        }

        while (i < n && intervals[i][0] <= newInterval[1])
        {
            newInterval[0] = Math.Min(newInterval[0], intervals[i][0]);
            newInterval[1] = Math.Max(newInterval[1], intervals[i][1]);
            i++;
        }

        result.Add(newInterval);

        while (i < n)
        {
            result.Add(intervals[i]);
            i++;
        }

        return result;
    }
}
