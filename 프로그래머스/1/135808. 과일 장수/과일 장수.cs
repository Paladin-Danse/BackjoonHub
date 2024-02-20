using System;
using System.Linq;
public class Solution {
    public int solution(int k, int m, int[] score) {
        int answer = 0;
        
        score = score.OrderByDescending(i => i).ToArray();
        int cnt = 0, min = 10;
        int[] appleBox = new int[m];
        for(int i = 0; i < score.Length; i++)
        {
            if(cnt >= appleBox.Length)
            {
                cnt = 0;
                answer += min * appleBox.Length;
                min = 10;
            }
            int temp = score[i] > k ? k : score[i];
            min = min > temp ? temp : min;
            appleBox[cnt++] = temp;
        }
        if(cnt >= appleBox.Length)
            answer += min * appleBox.Length;
        
        return answer;
    }
}