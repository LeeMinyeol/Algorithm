public class Solution {
    public int[] solution(long n) {
        string sol = n.ToString();
        int[] answer = new int[sol.Length];
        for(int i = 0; i < sol.Length; i++) {
           answer[i] = (int)(n % 10);
            n = n/10;
        }
        
        
        return answer;
    }
}