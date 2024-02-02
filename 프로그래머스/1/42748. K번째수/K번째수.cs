using System;
public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int[] answer = new int[commands.GetLength(0)];
        
        for(int i = 0; i < commands.GetLength(0); i++)
        {
            int[] arr = new int[commands[i,1] - commands[i,0] + 1];
            int cnt = 0;
            for(int j = commands[i,0] - 1; j <= commands[i,1] - 1; j++)
            {
                arr[cnt++] = array[j];
            }
            Array.Sort(arr);
            
            answer[i] = arr[commands[i,2] - 1];
        }
        
        return answer;
    }
}