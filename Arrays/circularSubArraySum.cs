//practise gfg link : https://www.geeksforgeeks.org/batch/gfg-160-problems/track/arrays-gfg-160/problem/maximum-product-subarray3604
public class Solution
{
    public int circularSubarraySum(List<int> arr)
    {
        int maxSum = arr[0], minSum = arr[0];
        int totalSum = arr[0], currMax = arr[0], currMin = arr[0];

        for (int i = 1; i < arr.Count; i++)
        {
            int val = arr[i];
            currMax = Math.Max(val, currMax + val);
            maxSum = Math.Max(maxSum, currMax);

            currMin = Math.Min(val, currMin + val);
            minSum = Math.Min(minSum, currMin);

            totalSum += val;
        }

        return (maxSum < 0) ? maxSum : Math.Max(maxSum, totalSum - minSum);
    }
}
