using System;

class Solution
{
    public long solution(int price, int money, int count) // 이용료, 소지금, 이용 횟수
    {
        long result = price * (long)(count * (1 + count) / 2);
        if(result <= money) return 0;
        else return result - (long)money;
    
    }
}