using System;
using System.Text;

public class Solution {
    public string solution(string s, string skip, int index) {
        StringBuilder answer = new StringBuilder();
        
        for(int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            for(int j = 0; j < index;)
            {
                c = (char)((int)c + 1);
                
                if(c > 'z') c = 'a';
                
                if(skip.Contains(c))
                {
                    continue;
                }
                j++;
            }
            answer.Append(c);
        }
        return answer.ToString();
    }
}