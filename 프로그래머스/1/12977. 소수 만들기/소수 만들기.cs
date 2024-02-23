using System;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;

        for(int i = 0; i < nums.Length - 2; i++)
        {
            for(int j = i + 1; j < nums.Length - 1; j++)
            {
                for(int k = j + 1; k < nums.Length; k++)
                {
                    if(PrimeNumber(nums[i] + nums[j] + nums[k]))
                        answer++;
                    else
                        continue;
                }
            }
        }
        
        return answer;
    }
    public bool PrimeNumber(int sum)
    {
        for(int i = 2; i * i <= sum; i++)
        {
            if(sum % i == 0) return false;
        }
        return true;
    }
}