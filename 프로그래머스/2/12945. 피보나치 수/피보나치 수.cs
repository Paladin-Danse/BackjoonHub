public class Solution {
    public int solution(int n) {
        int answer = 0;
        int a = 1;
        int b = 0;
            
        for(int i = 1; i < n; i++)
        {
            answer = (a + b) % 1234567;
            b = a;
            a = answer;
        }
        
        return answer;
    }
}