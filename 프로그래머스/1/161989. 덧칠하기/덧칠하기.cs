using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int n, int m, int[] section) {
        Dictionary<int, bool> d_sections = new Dictionary<int, bool>();
        int answer = 0;
        
        for(int i = 0; i < section.Length; i++)
        {
            d_sections.Add(section[i], false);
        }
        
        for(int i = 0; i < section.Length; i++)
        {
            if(!d_sections[section[i]])
            {
                for(int j = 0; j < m; j++)
                {
                    if(d_sections.ContainsKey(section[i] + j)) d_sections[section[i] + j] = true;
                }
                answer++;
            }
        }
        
        return answer;
    }
}