using System;
using System.Linq;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        string str = "";
        
        while(n != 0)
        {
            str += (n % 3).ToString();
            n /= 3;
        }
        int pow = 0;
        foreach(char c in str.Reverse())
        {
            int sum = int.Parse(c.ToString()) * (int)Math.Pow(3, pow++);
            answer += sum;
        }
        
        return answer;
    }
}