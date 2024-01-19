public class Solution {
    public string solution(string s) {
        string answer =
            s.Length % 2 == 0 ? s.Substring((s.Length - 1) / 2, 2) : s.Substring(s.Length / 2, 1);
        return answer;
    }
}