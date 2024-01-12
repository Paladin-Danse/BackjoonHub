public class Solution {
    public int[] solution(long n) {
        int[] answer = new int[n.ToString().Length];
        int cnt = 0;
        
        while(n != 0)
        {
            //long rem = 
            answer[cnt++] = (int)(n % 10);
            n /= 10;
        }
        
        return answer;
    }
}