public class Solution {
    public bool solution(int x) {
        bool answer = true;
        int sum = 0, rem = x;
        while(rem!=0)
        {
            sum += rem % 10;
            rem /= 10;
        }
        answer = (x % sum == 0 ? true : false);
        return answer;
    }
}