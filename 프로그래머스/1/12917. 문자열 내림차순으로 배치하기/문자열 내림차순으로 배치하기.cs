using System.Linq;

public class Solution {
    public string solution(string s) {
        s = string.Concat(s.OrderByDescending(c => c));
        return s;
    }
}