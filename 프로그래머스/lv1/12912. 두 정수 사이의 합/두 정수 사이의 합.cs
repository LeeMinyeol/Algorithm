public class Solution {
    public long solution(int a, int b) {
            long answer = 0;
            long sum = 0;
            if(a > b)
            {
                while(a >= b)
                {
                    sum += b;
                    b++;
                }

            } else
            {
                while (b >= a)
                {
                    sum += a;
                    a++;
                }

            }
            answer = sum;
        return answer;
    }
}