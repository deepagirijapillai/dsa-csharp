//practise gfg link : https://www.geeksforgeeks.org/batch/gfg-160-problems/track/searching-gfg-160/problem/search-in-a-rotated-array4618
class Solution
{
    public int search(int[] arr, int key)
    {
        int low = 0, high = arr.Length - 1;
        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            if (arr[mid] == key)
            {
                return mid;
            }

            else if (arr[low] <= arr[mid])
            {
                if (arr[low] <= key && key < arr[mid])
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            else
            {
                if (arr[mid] < key && key <= arr[high])
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
        }
        return -1;
    }
}