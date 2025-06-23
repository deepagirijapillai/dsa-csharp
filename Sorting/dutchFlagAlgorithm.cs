//practise gfg link : https://www.geeksforgeeks.org/batch/gfg-160-problems/track/sorting-gfg-160/problem/sort-an-array-of-0s-1s-and-2s4231
public class Solution
{
    public void Sort012(int[] arr)
    {
        int low = 0, mid = 0, high = arr.Length - 1;

        while (mid <= high)
        {
            if (arr[mid] == 0)
            {
                Swap(arr, low, mid);
                low++;
                mid++;
            }
            else if (arr[mid] == 1)
            {
                mid++;
            }
            else
            {
                Swap(arr, mid, high);
                high--;
            }
        }
    }

    private void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}
