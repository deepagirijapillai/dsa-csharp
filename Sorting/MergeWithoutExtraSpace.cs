//practise gfg link : https://www.geeksforgeeks.org/batch/gfg-160-problems/track/sorting-gfg-160/problem/merge-two-sorted-arrays-1587115620
class Solution
{
    public void mergeArrays(int[] a, int[] b)
    {
        int i = 0, j = a.Length - 1;

        while (i < b.Length && j >= 0)
        {
            if (a[j] >= b[i])
            {
                int temp = a[j];
                a[j] = b[i];
                b[i] = temp;
            }
            i++; j--;
        }

        Array.Sort(a);
        Array.Sort(b);
    }
}