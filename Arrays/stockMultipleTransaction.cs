//practise gfg link : https://www.geeksforgeeks.org/batch/gfg-160-problems/track/arrays-gfg-160/problem/stock-buy-and-sell2615
class Solution
{
    public int MaximumProfit(int[] prices)
    {
        int res = 0;
        for (int i = 0; i < prices.Length - 1; i++)
        {
            if (prices[i] < prices[i + 1])
                res += prices[i + 1] - prices[i];
        }
        return res;
    }
}