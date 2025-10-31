//practise gfg link : https://www.geeksforgeeks.org/batch/gfg-160-problems/track/searching-gfg-160/problem/number-of-occurrence2259
class Solution
{
    public int countFreq(int[] arr, int target)
    {
        // code here
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < arr.Length; i++)
        {
            if (!dict.ContainsKey(arr[i]))
            {
                dict.Add(arr[i], dict.GetValueOrDefault(arr[i]) + 1);
            }
            else
            {
                dict[arr[i]]++;
            }
        }

        return dict.GetValueOrDefault(target);
    }
}