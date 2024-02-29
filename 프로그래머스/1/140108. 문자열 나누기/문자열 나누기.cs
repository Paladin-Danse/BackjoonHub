using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        int equalCnt = 1;
        int diffCnt = 0;
        char x = s[0];
        
        for(int i = 1; i < s.Length; i++)
        {
            if(equalCnt == diffCnt)
            {
                x = s[i];
                answer++;
            }
            if(s[i] == x) equalCnt++;
            else diffCnt++;
        }
        return answer + 1;
    }
}