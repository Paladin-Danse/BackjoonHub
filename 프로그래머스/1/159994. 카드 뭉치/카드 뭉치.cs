using System;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        string answer = "";
        int card1cnt = 0;
        int card2cnt = 0;
        
        foreach(string str in goal)
        {
            if(str == cards1[card1cnt])
            {
                if(card1cnt < cards1.Length - 1) card1cnt++;
                continue;
            }
            else if(str == cards2[card2cnt])
            {
                if(card2cnt < cards2.Length - 1) card2cnt++;
                continue;
            }
            else
                return "No";
        }
        
        return "Yes";
    }
}