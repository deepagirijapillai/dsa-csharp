//practise gfg link : https://www.geeksforgeeks.org/batch/gfg-160-problems/track/arrays-gfg-160/problem/buy-stock-2
class Solution
{
	public int MaximumProfit(int[] prices)
	{
		int res = 0, min = prices[0];
		foreach (int price in prices)
		{
			min = Math.Min(min, price);
			res = Math.Max(res, price - min);
		}

		return res;
	}
}