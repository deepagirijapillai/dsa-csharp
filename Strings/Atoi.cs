//practise gfg link : https://www.geeksforgeeks.org/batch/gfg-160-problems/track/string-gfg-160/problem/implement-atoi

public class Solution
{
    public int MyAtoi(string s)
    {
        int n = s.Length;
        int i = 0, sign = 1, result = 0;

        while (i < n && s[i] == ' ')
        {
            i++;
        }

        if (i < n && (s[i] == '-' || s[i] == '+'))
        {
            if (s[i] == '-')
                sign = -1;

            i++;
        }

        while (i < n && s[i] >= '0' && s[i] <= '9')
        {
            if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && s[i] - '0' > 7))
            {
                return sign == -1 ? int.MinValue : int.MaxValue;
            }

            result = 10 * result + (s[i] - '0');
            i++;
        }

        return result * sign;
    }
}
