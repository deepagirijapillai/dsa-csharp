//practise gfg link : https://www.geeksforgeeks.org/batch/gfg-160-problems/track/arrays-gfg-160/problem/maximum-product-subarray3604
public class Solution
{
    public int MaxProduct(int[] nums)
    {
        int product = int.MinValue;
        int n = nums.Length;
        int leftToRight = 1, rightToLeft = 1;

        for (int i = 0; i < n; i++)
        {
            if (leftToRight == 0)
                leftToRight = 1;
            if (rightToLeft == 0)
                rightToLeft = 1;

            leftToRight *= nums[i];
            rightToLeft *= nums[n - 1 - i];

            product = Math.Max(product, Math.Max(leftToRight, rightToLeft));
        }

        return product;
    }
}
