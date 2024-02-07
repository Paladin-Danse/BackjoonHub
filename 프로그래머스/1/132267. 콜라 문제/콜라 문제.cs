using System;

public class Solution {
    public int solution(int a, int b, int n) {
        int answer = 0;
        int rem = 0;
        
        while(n >= a)
        {
            rem = n % a;
            int payback = (n / a) * b;
            answer += payback;
            n = payback + rem;
        }
        
        return answer;
    }
}