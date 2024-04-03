using System;

public class Solution {
    public int[] solution(int brown, int yellow) {
        int[] answer = new int[2];
        int area = brown + yellow;
    
        for(int i = 3; i <= area; i++)
        {
            if(area % i != 0) continue;
            int height = i;
            int width = area / i;

            if((height - 2) * (width - 2) == yellow)
            {
                answer[0] = width;
                answer[1] = height;
                break;
            }
        }
        return answer;
    }
}