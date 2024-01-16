public class Solution {
    public string solution(string phone_number) {
        string answer = new string('*', phone_number.Length - 4);
        return answer + phone_number.Substring(phone_number.Length - 4);
    }
}