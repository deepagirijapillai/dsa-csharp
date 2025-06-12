//practise gfg link : https://www.geeksforgeeks.org/batch/gfg-160-problems/track/arrays-gfg-160/problem/reverse-an-array
class Solution
{

    // function to reverse an array
    static void reverseArray(int[] arr)
    {
        int n = arr.Length, i = 0;
        while (i < n / 2)
        {
            int temp = arr[i];
            arr[i] = arr[n - i - 1];
            arr[n - i - 1] = temp;

            i++;
        }
    }
}