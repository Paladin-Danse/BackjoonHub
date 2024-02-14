using System;

public class Solution {
    public string solution(int a, int b) {
        string[] DOTWeek = new string[7] {"SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT"};
        DateTime year2016 = new DateTime(2016, a, b);
        string answer = DOTWeek[(4 + year2016.DayOfYear) % 7];
        
        return answer;
    }
}