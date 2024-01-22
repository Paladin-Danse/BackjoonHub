public class Solution {
    public bool solution(string s) {
        bool answer = false;
        
        if(s.Length == 4 || s.Length == 6)
        {
            int rem;
            if(int.TryParse(s, out rem))
            {
                answer = true;
            }
        }
        
        return answer;
    }
}