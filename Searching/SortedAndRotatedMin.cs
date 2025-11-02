//practise gfg link : https://www.geeksforgeeks.org/batch/gfg-160-problems/track/searching-gfg-160/problem/minimum-element-in-a-sorted-and-rotated-array3611
public class Solution
{
    public int FindMin(int[] arr)
    {
        int low = 0, high = arr.Length - 1;
        while (low < high)
        {
            int mid = low + (high - low) / 2;
            if (arr[mid] > arr[high])
            {
                low = mid + 1;
            }
            else
            {
                high = mid;
            }
        }
        return arr[low];
    }
}
