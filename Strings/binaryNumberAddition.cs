//practise gfg link : https://www.geeksforgeeks.org/batch/gfg-160-problems/track/string-gfg-160/problem/add-binary-strings3805
public class Solution
{
    public string AddBinary(string s1, string s2)
    {
        s1 = TrimLeadingZeroes(s1);
        s2 = TrimLeadingZeroes(s2);

        int n = s1.Length, m = s2.Length;
        if (m > n)
            return AddBinary(s2, s1);

        char[] result = new char[n];
        int i = n - 1, j = m - 1, carry = 0;

        while (i >= 0)
        {
            int bit1 = s1[i] - '0';
            int sum = bit1 + carry;

            if (j >= 0)
            {
                int bit2 = s2[j] - '0';
                sum += bit2;
                j--;
            }

            result[i] = (char)((sum % 2) + '0');
            carry = sum / 2;
            i--;
        }

        string resStr = new string(result);
        return carry > 0 ? "1" + resStr : resStr;
    }

    private string TrimLeadingZeroes(string s)
    {
        int i = 0;
        while (i < s.Length && s[i] == '0')
            i++;
        return i == s.Length ? "0" : s.Substring(i);
    }
}
