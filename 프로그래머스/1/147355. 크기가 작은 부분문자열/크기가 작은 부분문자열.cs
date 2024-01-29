using System;

public class Solution {
    public int solution(string t, string p) {
        int answer = 0;
        
        for(int i = 0; i + p.Length <= t.Length; i++)
        {
            string str = t.Substring(i, p.Length);
            if(long.Parse(p) >= long.Parse(str)) answer++;
        }
        return answer;
    }
}