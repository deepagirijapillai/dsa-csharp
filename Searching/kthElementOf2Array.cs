//practise gfg link : https://www.geeksforgeeks.org/batch/gfg-160-problems/track/searching-gfg-160/problem/k-th-element-of-two-sorted-array1317
class Solution
{
    public int kthElement(int[] a, int[] b, int k)
    {
        // code here
        int n1 = a.Length, n2 = b.Length;
        if (n1 > n2) return kthElement(b, a, k);

        int low = Math.Max(0, k - n2);
        int high = Math.Min(k, n1);
        while (low <= high)
        {
            int cut1 = (high + low) / 2;
            int cut2 = k - cut1;
            int l1 = (cut1 == 0) ? int.MinValue : a[cut1 - 1];
            int r1 = (cut1 == n1) ? int.MaxValue : a[cut1];

            int l2 = (cut2 == 0) ? int.MinValue : b[cut2 - 1];
            int r2 = (cut2 == n2) ? int.MaxValue : b[cut2];

            if (l1 <= r2 && l2 <= r1)
            {
                return Math.Max(l1, l2);
            }
            else if (l1 > r2)
            {
                high = cut1 - 1;
            }
            else
            {
                low = cut1 + 1;
            }
        }

        return -1;
    }
}