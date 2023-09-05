public class Solution {
    public bool solution(int x) {
        bool answer = true;
            string s = x.ToString();
            int sum = 0;
            foreach (char c in s)
            {
                sum += int.Parse(c.ToString());
            }

            if (x % sum == 0)
            {
                answer =  true;
            } else
            {
                answer = false;
            }


            return answer;
    }
}