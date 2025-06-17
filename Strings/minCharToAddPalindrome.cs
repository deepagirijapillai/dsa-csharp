//practise gfg link : https://www.geeksforgeeks.org/batch/gfg-160-problems/track/string-gfg-160/problem/minimum-characters-to-be-added-at-front-to-make-string-palindrome
using System;
using System.Text;

public class Solution
{
    public static int MinChar(string s)
    {
        string rev = Reverse(s);
        string combined = s + '$' + rev;
        int[] lps = LPS(combined);

        return s.Length - lps[combined.Length - 1];
    }

    private static string Reverse(string s)
    {
        var sb = new StringBuilder(s);
        var charArray = sb.ToString().ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    private static int[] LPS(string pattern)
    {
        int n = pattern.Length;
        int[] lps = new int[n];
        int len = 0;
        int i = 1;

        while (i < n)
        {
            if (pattern[i] == pattern[len])
            {
                len++;
                lps[i] = len;
