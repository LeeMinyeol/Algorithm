using System;

public class Solution {
    public int solution(int left, int right) {
        int answer = 0;
        int count = 0;
        
        for(int i = left; i >= left && i <= right; i++ ) { //나누어 떨어지는 '수' 검사
            for(int y = 1; y <= i; y++) { // '약수' 검사
                if(i % y == 0) { //약수
                    count++;
                }
            }
            if(count % 2 == 0) {
                answer += i;
                count = 0;
            } else {
                answer -= i;
                count = 0;
            } 
        }
        
        return answer;
    }
}