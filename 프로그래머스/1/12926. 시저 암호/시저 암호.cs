using System;
public class Solution {
    public string solution(string s, int n) {
        string answer = "";
        
        for(int i = 0; i < s.Length; i++)
        {
            int c;
            
            if(s[i] >= 'a' && s[i] <= 'z')
                c = (s[i] + n) - 'a' > 25 ? (s[i] + n) - 26 : s[i] + n;
            else if(s[i] >= 'A' && s[i] <= 'Z')
                c = (s[i] + n) - 'A' > 25 ? (s[i] + n) - 26 : s[i] + n;
            else
                c = ' ';
            
            answer += (char)c;
        }
        return answer;
    }
}