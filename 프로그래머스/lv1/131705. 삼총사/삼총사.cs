using System;

public class Solution {
    public int solution(int[] number) {
        int answer = 0;
        answer = Triple(number);
        
        return answer;
    }
    
    private int Triple(int[] num) {
        int count = 0;
        for(int i = 0; i < num.Length; i++) {
            for(int j = i + 1; j < num.Length; j++) {
                for(int k = j + 1; k < num.Length; k++) {
                    
                    if((num[i] + num[j] + num[k]) == 0) count++;

                }
            }
        }
        
        return count;
    }
}