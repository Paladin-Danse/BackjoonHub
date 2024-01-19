using System;
using System.Linq;

public class Solution {
    public int solution(int left, int right) {
        int answer = 0;
        
        for(int i = left; i <= right; i++)
        {
            int Divisor = 0;
            for(int j = 1; j * j <= i; j++)
            {
                if(i % j == 0) 
                {
                    if(i == j * j)
                        Divisor += 1;
                    else
                        Divisor += 2;
                }
            }
            answer += Divisor % 2 == 0 ? i : -i;
        }
        
        return answer;
    }
}