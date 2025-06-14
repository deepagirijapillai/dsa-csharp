//practise gfg link : https://www.geeksforgeeks.org/batch/gfg-160-problems/track/arrays-gfg-160/problem/majority-vote
class Solution
{
	public List<int> FindMajority(List<int> nums)
	{
		List<int> res = new List<int>();
		int count1 = 0, count2 = 0, ele1 = 0, ele2 = 1;

		foreach (int num in nums)
		{
			if (num == ele1)
			{
				count1++;
			}
			else if (num == ele2)
			{
				count2++;
			}
			else if (count1 == 0)
			{
				ele1 = num;
				count1 = 1;
			}
			else if (count2 == 0)
			{
				ele2 = num;
				count2 = 1;
			}
			else
			{
				count1--;
				count2--;
			}
		}
		count1 = 0; count2 = 0;

		foreach (int num in nums)
		{
			if (num == ele1)
			{
				count1++;
			}
			else if (num == ele2)
			{
				count2++;
			}
		}

		if (count1 > nums.Count / 3) res.Add(ele1);
		if (count2 > nums.Count / 3) res.Add(ele2);
		res.Sort();
		return res;
	}
}