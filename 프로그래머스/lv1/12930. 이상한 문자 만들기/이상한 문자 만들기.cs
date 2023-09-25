using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
        string[] a = s.Split();
        
        for(int i = 0; i < a.Length; i++) {
            for(int j = 0; j < a[i].Length; j++) {
                if(j == 0) {
                    answer += Char.ToUpper(a[i][j]);
                    continue;
                }
                if(j % 2 == 0) {
                    answer += Char.ToUpper(a[i][j]);
                } else {
                    answer += Char.ToLower(a[i][j]);
                }
            }
            if(i != a.Length-1) {
                answer += " ";
            }
        }
        
        
        
        return answer;
    }
}