//practise gfg link : https://www.geeksforgeeks.org/batch/gfg-160-problems/track/searching-gfg-160/problem/peak-element
class Solution
{
    public int peakElement(int[] arr)
    {
        int low = 0, high = arr.Length - 1;
        while (low < high)
        {
            int mid = low + (high - low) / 2;
            if (arr[mid] < arr[mid + 1])
            {
                low = mid + 1;
            }
            else
            {
                high = mid;
            }
        }

        return low;
    }
}