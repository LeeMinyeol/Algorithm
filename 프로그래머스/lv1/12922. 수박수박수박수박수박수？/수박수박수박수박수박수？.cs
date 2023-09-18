public class Solution {
    public string solution(int n) {
        string answer = "";
        bool isTrigger = true;
        for(int i = 0; i < n; i++) { //n갯수만큼 돌기
            if(isTrigger == true) {
                answer += "수";// 수 넣기
                isTrigger = false;
            } else {
                answer += "박";// 박 넣기
                isTrigger = true;
            }
        }
        
        return answer;
    }
}