public class Solution {
    public bool solution(string s) { //문자열 길이 4 or 6, 숫자로만 구성되어있는지 확인
        bool answer = false;

        if(s.Length == 4 || s.Length == 6) {
            answer = int.TryParse(s, out int i);
        }
            
        
        
        return answer;
    }
}