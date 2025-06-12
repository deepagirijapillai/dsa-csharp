//practise gfg link : https://www.geeksforgeeks.org/batch/gfg-160-problems/track/arrays-gfg-160/problem/move-all-zeroes-to-end-of-array0751
class Solution
{
    static void pushZeroToArrayEnd(int[] arr)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {

            if (arr[i] != 0)
            {
                int temp = arr[i];
                arr[i] = arr[count];
                arr[count] = temp;

                count++;
            }
        }
    }
}