//practise gfg link : https://www.geeksforgeeks.org/batch/gfg-160-problems/track/arrays-gfg-160/problem/kadanes-algorithm-1587115620
class Solution
{
    public int MaxSubarraySum(int[] arr)
    {
        int sum = arr[0], res = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            sum = Math.Max(sum + arr[i], arr[i]);
            res = Math.Max(res, sum);
        }

        return res;
    }
}