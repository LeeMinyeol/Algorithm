public class Solution {
    public string solution(string s) { //s의 문자를 내림차순 정렬
        string answer = "";
        char[] charArr = s.ToCharArray();
        
        System.Array.Sort(charArr);
        System.Array.Reverse(charArr);
        
        answer = new string(charArr);
        
        
        return answer;
    }
}