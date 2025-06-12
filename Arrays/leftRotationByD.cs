//practise gfg link : https://www.geeksforgeeks.org/batch/gfg-160-problems/track/arrays-gfg-160/problem/rotate-array-by-n-elements-1587115621
class Solution
{
    static void rotateArr(int[] arr, int d)
    {
        int n = arr.Length;
        d %= n;
        reverse(arr, 0, d - 1);
        rev(arr, d, n - 1);
        rev(arr, 0, n - 1);
    }

    static void rev(int[] arr, int start, int end)
    {
        while (start < end)
        {
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            start++;
            end--;
        }
    }
}