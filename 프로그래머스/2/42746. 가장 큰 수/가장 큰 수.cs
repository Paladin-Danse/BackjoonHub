using System;
using System.Text;
using System.Collections.Generic;

public class Solution {
    public int cmp(int a, int b)
    {
        string s1 = a.ToString() + b.ToString();
        string s2 = b.ToString() + a.ToString();
        return int.Parse(s1) > int.Parse(s2) ? -1 : 1;
    }
    public string solution(int[] numbers) {
        StringBuilder answer = new StringBuilder();
        List<int> numberList = new List<int>(numbers);
        
        numberList.Sort((n1, n2) => cmp(n1, n2));
        
        foreach(int number in numberList)
            answer.Append(number.ToString());
        
        int temp;
        
        if(int.TryParse(answer.ToString(), out temp))
        {
            if(temp == 0)
            {
                answer.Length = 0;
                answer.Append("0");
            }
        }
        
        return answer.ToString();
    }
}