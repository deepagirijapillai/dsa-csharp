//practise gfg link : https://www.geeksforgeeks.org/batch/gfg-160-problems/track/searching-gfg-160/problem/aggressive-cows
public class Solution
{
    public int AggressiveCows(int[] stalls, int cows)
    {
        if (stalls == null || stalls.Length == 0)
            return 0;

        Array.Sort(stalls);

        int low = 0;
        int high = stalls[^1] - stalls[0];

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (CanPlaceCows(stalls, cows, mid))
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        return high;
    }

    private bool CanPlaceCows(int[] stalls, int cows, int minDistance)
    {
        int cowsPlaced = 1;
        int lastPlaced = stalls[0];

        for (int i = 1; i < stalls.Length; i++)
        {
            if (stalls[i] - lastPlaced >= minDistance)
            {
                cowsPlaced++;
                lastPlaced = stalls[i];

                if (cowsPlaced >= cows)
                    return true;
            }
        }

        return false;
    }
}
