//practise gfg link : https://www.geeksforgeeks.org/batch/gfg-160-problems/track/arrays-gfg-160/problem/minimize-the-heights3351
class Solution
{
    public int GetMinDiff(int[] arr, int k)
    {
        int n = arr.Length - 1;
        Array.Sort(arr);
        int res = arr[n] - arr[0];
        for (int i = 0; i < n; i++)
        {
            int smallest = Math.Min(arr[0] + k, arr[i + 1] - k);
            int largest = Math.Max(arr[n] - k, arr[i] + k);
            if (smallest < 0)
                continue;

            res = Math.Min(res, largest - smallest);
        }

        return res;
    }
}
