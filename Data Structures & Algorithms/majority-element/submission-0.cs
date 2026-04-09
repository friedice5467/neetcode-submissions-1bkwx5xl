public class Solution {
    public int MajorityElement(int[] nums) {
        var map = new Dictionary<int, int>();
        var max = 0;
        var result = 0;

        foreach (var n in nums) {
            map[n] = map.TryGetValue(n, out var count) ? count + 1 : 1;

            if (map[n] > max) {
                max = map[n];
                result = n;
            }
        }

        return result;
    }
}