using System;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[2];
        int cnt = 0;
        int repeat = 0;
        
        while(s != "1")
        {
            repeat++;
            int zeroCnt = 0;
            for(int i = 0; i < s.Length; i++)
            {
                if(s[i] == '0')
                {
                    zeroCnt++;
                }
            }
            int newLength = s.Length - zeroCnt;
            cnt += zeroCnt;
            
            s = Convert.ToString(newLength, 2);
        }
        
        answer[0] = repeat;
        answer[1] = cnt;
        
        return answer;
    }
}