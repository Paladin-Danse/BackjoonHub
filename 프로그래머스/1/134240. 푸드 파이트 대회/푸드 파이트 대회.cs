using System;
using System.Text;
public class Solution {
    public string solution(int[] food) {
        StringBuilder answer = new StringBuilder("0");
        
        for(int i = food.Length - 1; i >= 1; i--)
        {
            StringBuilder str = new StringBuilder("");
            for(int j = 0; j < food[i] / 2; j++)
            {
                str.Append(i.ToString());
                answer.Append(i.ToString());
            }
            str.Append(answer);
            answer = str;
        }
        
        return answer.ToString();
    }
}