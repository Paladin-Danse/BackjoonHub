using System.Linq;
public class Solution {
    public string[] solution(string[] strings, int n) {
        string[] answer = new string[] {};
        
        strings = strings.OrderBy(i => i[n]).ThenBy(i => i).ToArray();
        
        return strings;
    }
}