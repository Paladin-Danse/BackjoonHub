public class Solution {
    public string solution(string s) {
        string answer = "";
        int count = 0;
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] != ' ')
            {
                if(count % 2 == 0)
                    answer += s.ToUpper().Substring(i, 1);
                else
                    answer += s.ToLower().Substring(i, 1);
                count++;
            }
            else
            {
                answer += " ";
                count = 0;
            }
        }
        return answer;
    }
}