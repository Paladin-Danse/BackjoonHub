using System;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        int answer = 0;
        int[] gymSuit = new int[n + 2];
        
        for(int i = 0; i < gymSuit.Length; i++)
            gymSuit[i] = 1;
        for(int i = 0; i < lost.Length; i++)
            gymSuit[lost[i]]--;
        for(int i = 0; i < reserve.Length; i++)
            gymSuit[reserve[i]]++;
        
        for(int i = 1; i <= n; i++)
        {
            if(gymSuit[i - 1] == 0 && gymSuit[i] == 2) gymSuit[i - 1] = gymSuit[i] = 1;
            else if(gymSuit[i] == 2 && gymSuit[i + 1] == 0) gymSuit[i] = gymSuit[i + 1] = 1;
        }
        for(int i = 1; i <= n; i++)
        {
            if(gymSuit[i] > 0) answer++;
        }
        
        return answer;
    }
}