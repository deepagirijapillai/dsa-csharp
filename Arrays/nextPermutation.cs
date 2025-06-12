//practise gfg link : https://www.geeksforgeeks.org/batch/gfg-160-problems/track/arrays-gfg-160/problem/next-permutation5226
class Solution
{
    public void NextPermutation(int[] arr)
    {
        int pivot = -1, n = arr.Length;
        for (int i = n - 2; i >= 0; i--)
        {
            if (arr[i] < arr[i + 1])
            {
                pivot = i;
                break;
            }
        }
        if (pivot == -1)
        {
            Array.Reverse(arr);
            return;
        }
        for (int i = n - 1; i >= 0; i--)
        {
            if (arr[i] > arr[pivot])
            {
                int temp = arr[i];
                arr[i] = arr[pivot];
                arr[pivot] = temp;
                break;
            }
        }
        Array.Reverse(arr, pivot + 1, n - pivot - 1);
    }
}