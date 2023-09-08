public class Solution {
    public int solution(int num) {
            int answer = 0;
            long temp = num;
            while (temp != 1)
            {
                answer++;
                if (answer > 500)
                {
                    answer = -1;
                    break;
                }

                if (temp % 2 == 0)
                {//짝수
                    temp = temp / 2;
                }
                else
                {
                    temp = (temp * 3) + 1;
                }

            }
        return answer;
    }
}