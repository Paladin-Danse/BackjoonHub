using System;
using System.Text;

public class Solution {
    public string solution(string s) {
        string[] str;
        str = s.Split(' ');
        
        for(int i = 0; i < str.Length; i++)
        {
            if(str[i] == "") continue;
            string temp = str[i].ToLower();
            string temp2 = temp.Substring(0, 1).ToUpper();
            str[i] = temp2 + temp.Substring(1);
        }
        
        return string.Join(" ", str);
    }
}