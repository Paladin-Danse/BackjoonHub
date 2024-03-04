using System;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int[] answer = new int[2];
        int compareCnt = 0, zeroCnt = 0;
        for(int i = 0; i < lottos.Length; i++)
        {
            if(lottos[i] == 0)
                zeroCnt++;
            else if(Array.Exists(win_nums, num => num == lottos[i]))
                compareCnt++;
        }
        
        int minRank = 7;
        answer[0] = Math.Clamp(minRank - (compareCnt + zeroCnt), 1, 6);
        answer[1] = Math.Clamp(minRank - compareCnt, 1, 6);
        
        return answer;
    }
}