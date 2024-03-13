using System;

public class Solution {
    public int[] solution(string[] keymap, string[] targets) {
        int[] answer = new int[targets.Length];
        
        for(int i = 0; i < targets.Length; i++)
        {
            char c;
            for(int j = 0; j < targets[i].Length; j++)
            {
                c = targets[i][j];
                int min = 101;
                for(int k = 0; k < keymap.Length; k++)
                {
                    if(keymap[k].Contains(c))
                    {
                        if(min > keymap[k].IndexOf(c)) min = keymap[k].IndexOf(c) + 1;
                    }
                }
                if(min == 101)
                {
                    answer[i] = -1;
                    break;
                }
                answer[i] += min;
            }
            
        }
        
        return answer;
    }
}