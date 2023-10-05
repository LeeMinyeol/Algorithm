using System;

public class Solution {
    public int solution(int[,] sizes) {
        int answer = 0;
        int maxW = 0;
        int maxH = 0;
        
        for(int i = 0; i < sizes.GetLength(0); i++) {
            int width = sizes[i, 0];
            int height = sizes[i, 1];
            
            if(height > width) {
                width = sizes[i, 1];
                height = sizes[i, 0];
            }
            if(height > maxH) {
                maxH = height;
            }
            if(width > maxW) {
                maxW = width;
            }
        }
        answer = maxW * maxH;
        
        return answer;
    }
}