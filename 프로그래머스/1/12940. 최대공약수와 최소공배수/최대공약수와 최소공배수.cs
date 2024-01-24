public class Solution {
    public int[] solution(int n, int m) {
        int[] answer = new int[2];
        int a, b;
        
        if(n > m)
        {
            a = n;
            b = m;
        }
        else
        {
            a = m;
            b = n;
        }
        
        while(a % b != 0)
        {
            int temp = a;
            a = b;
            b = temp % b;
        }
        
        answer[0] = b;
        answer[1] = (m * n) / b;
        
        return answer;
    }
}