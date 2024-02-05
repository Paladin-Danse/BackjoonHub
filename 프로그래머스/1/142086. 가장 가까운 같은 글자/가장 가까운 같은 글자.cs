using System;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];
        answer[0] = -1;
        for(int i = 1; i < s.Length; i++)
        {
            string str = s.Substring(0, i);
            answer[i] = str.Contains(s[i]) ? i - str.LastIndexOf(s[i]) : -1;
        }
        
        return answer;
    }
}