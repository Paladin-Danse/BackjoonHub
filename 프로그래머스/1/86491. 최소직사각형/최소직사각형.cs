using System;

public class Solution {
    public int solution(int[,] sizes) {
        int maxWidth = 0, maxHeight = 0;
        for(int i = 0; i < sizes.Length / 2; i++)
        {
            int _min, _max;
            
            if(sizes[i, 0] < sizes[i, 1])
            {
                _min = sizes[i, 0];
                _max = sizes[i, 1];
            }
            else
            {
                _min = sizes[i, 1];
                _max = sizes[i, 0];
            }
            
            if(maxWidth < _min) maxWidth = _min;
            if(maxHeight < _max) maxHeight = _max;
        }
        
        return maxWidth * maxHeight;
    }
}