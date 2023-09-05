public class Solution {
    public long solution(long n) {
        long answer = 0;
        string temp = n.ToString();
        char[] cTemp = temp.ToCharArray();
        System.Array.Sort(cTemp);
        System.Array.Reverse(cTemp);
        answer = long.Parse(cTemp);

        return answer;
    }
    
}