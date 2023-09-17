public class Solution {
    public string solution(string[] seoul) {
        string answer = "";
        int count = 0;
        //seoul중에 kim 찾기
        foreach(string fName in seoul) {
            
            if(fName.Equals("Kim")) break;
            else count++;
        }
        answer = $"김서방은 {count}에 있다";
        
        return answer;
    }
}