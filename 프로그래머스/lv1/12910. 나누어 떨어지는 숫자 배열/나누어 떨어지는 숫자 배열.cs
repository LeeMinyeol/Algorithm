public class Solution {
    public int[] solution(int[] arr, int divisor) { // 나눈 나머지가 0인 수를 모아서 오름차순 정렬
        int[] answer = new int[arr.Length];
        int count = 0;
        
        for(int i = 0; i < arr.Length; i++) {
            if(arr[i] % divisor == 0) {
                answer[count] = arr[i];
                count++;
            }
        }
        if(count != 0) {
           System.Array.Resize(ref answer, count);
           System.Array.Sort(answer);
        } else {
           System.Array.Resize(ref answer, 1);
            answer[0] = -1;
        }
        
        return answer;
    }
}