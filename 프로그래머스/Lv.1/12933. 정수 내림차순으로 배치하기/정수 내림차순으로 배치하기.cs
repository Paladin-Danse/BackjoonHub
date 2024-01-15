using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        List<int> i_array = new List<int>();
        while(n != 0)
        {
            answer = n % 10;
            n /= 10;
            i_array.Add((int)answer);
        }
        
        string str = string.Join("", i_array.OrderByDescending(i => i).ToList());
        answer = long.Parse(str);
        
        return answer;
    }
}