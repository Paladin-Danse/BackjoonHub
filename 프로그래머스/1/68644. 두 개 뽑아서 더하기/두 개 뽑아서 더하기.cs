using System;
using System.Linq;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] numbers) {
        int[] answer = new int[] {};
        List<int> intList = new List<int>();
        for(int i = 0; i < numbers.Length - 1; i++)
        {
            for(int j = i + 1; j < numbers.Length; j++)
            {
                if(intList.Exists(x => x == numbers[i] + numbers[j]) == false)
                    intList.Add(numbers[i] + numbers[j]);
            }
        }
        answer = intList.OrderBy(x => x).ToArray();
        
        return answer;
    }
}