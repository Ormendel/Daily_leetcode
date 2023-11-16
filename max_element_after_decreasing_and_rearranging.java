import java.util.Arrays;
class Solution {
    public int maximumElementAfterDecrementingAndRearranging(int[] arr) {
         int n = arr.length;

        // Sort the array in ascending order
        Arrays.sort(arr);

        // Ensure the first element is 1 (minimum possible value)
        arr[0] = 1;

        // Ensure each subsequent element is at most one greater than the previous element
        for (int i = 1; i < n; i++) {
            arr[i] = Math.min(arr[i], arr[i - 1] + 1);
        }

        return arr[n - 1]; // The maximum element after rearranging
    }
}
