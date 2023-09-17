public class Solution {
    public int[] solution(int[] arr) { // 가장 작은 수 제거(찾기, 빼기), 리턴배열이 null => -1
        int[] answer = new int[arr.Length - 1];
        int min = int.MaxValue;
        int minIndex = 0;
        
        for(int i = 0; i < arr.Length; i++) {
            if(arr[i] < min) {
                min = arr[i];
                minIndex = i;
            }
        }
        
        if(answer.Length == 0) {
            answer = new int[] {-1};
        } else {
                    int ansNum = 0;
        for(int i = 0; i < arr.Length; i++) {
            if(min != arr[i]) {
                answer[ansNum] = arr[i];
                ansNum++;
            }
        }
        }

        
        return answer;
    }
}