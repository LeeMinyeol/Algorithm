using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        int numSum = 0;;
        for(int i = 0; i < 10; i++) {
            answer += i;
        }
        foreach(int num in numbers) {
            numSum += num;
        }
        answer -= numSum;
        
        return answer;
    }
}