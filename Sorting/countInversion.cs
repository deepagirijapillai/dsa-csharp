//practise gfg link : https://www.geeksforgeeks.org/batch/gfg-160-problems/track/sorting-gfg-160/problem/inversion-of-array-1587115620
class Solution
{
    // Function to count inversions in the array.
    public int InversionCount(int[] arr)
    {
        int[] temp = new int[arr.Length];

        return mergesort(arr, temp, 0, arr.Length - 1);
    }

    public int mergesort(int[] arr, int[] temp, int low, int high)
    {
        int count = 0;
        if (low < high)
        {
            int mid = (low + high) / 2;
            count += mergesort(arr, temp, low, mid);
            count += mergesort(arr, temp, mid + 1, high);
            count += merge(arr, temp, low, mid, high);
        }

        return count;
    }

    public int merge(int[] arr, int[] temp, int low, int mid, int high)
    {
        int res = 0;

        int i = low, k = low, j = mid + 1;
        while (i <= mid && j <= high)
        {
            if (arr[i] <= arr[j])
            {
                temp[k++] = arr[i++];
            }
            else
            {
                temp[k++] = arr[j++];
                res += (mid - i + 1);
            }
        }

        while (i <= mid)
        {
            temp[k++] = arr[i++];
        }
        while (j <= high)
        {
            temp[k++] = arr[j++];
        }

        for (int x = low; x <= high; x++)
        {
            arr[x] = temp[x];
        }

        return res;
    }
}
