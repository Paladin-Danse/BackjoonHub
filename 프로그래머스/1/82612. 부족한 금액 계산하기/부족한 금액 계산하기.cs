using System;

class Solution
{
    public long solution(int price, long money, int count)
    {
        long resultPrice = (long)price;
        for(int i = 0; i < count; i++)
        {
            money -= resultPrice;
            resultPrice += price;
        }
        
        return money < 0 ? -money : 0;
    }
}