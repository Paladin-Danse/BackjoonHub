public class Solution {
    public string solution(string[] seoul) {
        string answer = "김서방은 ";
        
        for(int i = 0; i < seoul.Length; i++)
        {
            if(seoul[i] == "Kim") answer += i.ToString();
        }
        
        return answer + "에 있다";
    }
}