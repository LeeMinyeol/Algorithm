using System;
public class Solution {
    public string[] solution(string[] strings, int n) {
        string[] answer = new string[strings.Length]; 
        
        for(int i = 0; i < strings.Length; i++) {
            answer[i] = strings[i][n] + strings[i];
        }
        
        Array.Sort(answer);
        
        for(int i = 0; i < strings.Length; i++) {
            answer[i] = answer[i].Substring(1);
        }
        
        return answer;
    }
}