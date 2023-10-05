using System;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int[] answer = new int[commands.GetLength(0)];
        
        for(int n = 0; n < commands.GetLength(0); n++) {
            int i = commands[n, 0];
            int j = commands[n, 1];
            int k = commands[n, 2];
            
            int[] temp = new int[j - i + 1];
      
            for(int a = 0; a < temp.Length; a++) {
                temp[a] = array[i - 1 + a];
            }
            Array.Sort(temp);
            answer[n] = temp[k-1];
        }
        
        return answer;
    }
}