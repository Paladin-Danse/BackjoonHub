public class Solution {
    public int solution(int num) {
        int answer = 0;
        long rem = num;
        while(rem != 1)
        {
            if(rem % 2 == 0) rem /= 2;
            else rem = (rem * 3) + 1;
            
            if(answer != 500) answer++;
            else
            {
                answer = -1;
                break;
            }
        }
        
        return answer;
    }
}