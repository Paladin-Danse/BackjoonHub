using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int[] ingredient) {
        int answer = 0;
        int[] hamburger = new int[4] {1, 2, 3, 1};
        List<int> ingredient_List = new List<int>();
        
        bool isEnd = false;
        
        foreach(int i in ingredient)
        {
            ingredient_List.Add(i);
            
            if(ingredient_List.Count >= 4)
            {
                if(ingredient_List[ingredient_List.Count - 4] == hamburger[0] &&
                    ingredient_List[ingredient_List.Count - 3] == hamburger[1] &&
                    ingredient_List[ingredient_List.Count - 2] == hamburger[2] &&
                    ingredient_List[ingredient_List.Count - 1] == hamburger[3])
                {
                    answer++;
                    ingredient_List.RemoveRange(ingredient_List.Count - 4, 4);
                }
            }
        }
        
        return answer;
    }
}