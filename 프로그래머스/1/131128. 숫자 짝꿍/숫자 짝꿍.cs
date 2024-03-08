using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string X, string Y) {
        List<char> answer = new List<char>();
        Dictionary<char, int> dict = new Dictionary<char, int>();

        for (int i = 0; i < X.Length; i++)
        {
            if (dict.ContainsKey(X[i]))
            {
                dict[X[i]]++;
            }
            else
            {
                dict.Add(X[i], 1);
            }
        }
        for(int i = 0; i < Y.Length; i++)
        {
            if(dict.ContainsKey(Y[i]))
            {
                if(dict[Y[i]] > 0)
                {
                    dict[Y[i]]--;
                    answer.Add(Y[i]);
                }
            }
        }
        answer.Sort(new Comparison<char>((c1, c2) => c2.CompareTo(c1)));
        string str;
        if (answer.Count == 0)
        {
            str = "-1";
        }
        else if (answer[0] == '0')
        {
            str = "0";
        }
        else
        {
            str = new string(answer.ToArray());
        }

        return str;
    }
}