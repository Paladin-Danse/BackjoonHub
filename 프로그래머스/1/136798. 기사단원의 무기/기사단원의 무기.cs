using System;

public class Solution {
    public int solution(int number, int limit, int power) {
        int answer = 0;
        
        for(int i = 1; i <= number; i++)
        {
            int divCnt = 0;
            for(int j = 1; j * j <= i; j++)
            {
                if(i % j == 0)
                {
                    if(j * j != i) divCnt++;
                    divCnt++;
                }
            }
            divCnt = divCnt > limit ? power : divCnt;
            answer += divCnt;
        }
        
        return answer;
    }
}