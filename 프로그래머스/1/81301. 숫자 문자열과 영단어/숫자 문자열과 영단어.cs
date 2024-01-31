using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        string[] numString = new string[10] {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
        
        while(!int.TryParse(s, out answer))
        {
            for(int i = 0; i < numString.Length; i++)
            {
                s = s.Replace(numString[i], i.ToString());
            }
        }
        
        return answer;
    }
}