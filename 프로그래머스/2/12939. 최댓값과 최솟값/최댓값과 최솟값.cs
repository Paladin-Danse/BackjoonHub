public class Solution {
    public string solution(string s) {
        string answer = "";
        string[] split = s.Split(' ');
        int min = int.Parse(split[0]);
        int max = int.Parse(split[0]);
        
        for(int i = 1; i < split.Length; i++)
        {
            int temp;
            if(int.TryParse(split[i], out temp))
            {
                if(min > temp) min = temp;
                if(max < temp) max = temp;
            }
        }
        
        answer = string.Format($"{min} {max}");
        
        return answer;
    }
}