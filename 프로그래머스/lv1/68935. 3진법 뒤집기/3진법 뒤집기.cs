using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        List<int> list = new List<int>();
        
        while(true) {
            if(n == 0) break;
            int d = n % 3;
            list.Add(d);
            n = n / 3;
        }
        
        list.Reverse();
        
        for(int i = 0; i < list.Count; i++) {
            answer += (int)(list[i] * Math.Pow(3, i));
        }
        //3진법 변환 -> 더 이상 나눠지지 않을때까지 3으로 나눔 while
        //3진법 뒤집기
        //10진법 변환

        
        return answer;
    }
}