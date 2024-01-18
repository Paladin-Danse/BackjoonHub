using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr)
    {
        List<int> answer = new List<int>();
        
        answer = arr.ToList();
        Array.Sort(arr);
        answer.RemoveAt(answer.IndexOf(arr[0]));
        arr = answer.Count == 0 ? new int[1] {-1} : answer.ToArray();
        
        return arr;
    }
}