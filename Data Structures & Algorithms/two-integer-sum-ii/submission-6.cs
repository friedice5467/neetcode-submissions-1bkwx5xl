public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var l = 0;
        var r = numbers.Length - 1;

        while(l < r)
        {
            var sum = numbers[l] + numbers[r];

            if(sum > target)
                r--;
            else if(sum < target)
                l++;
            else
                return new int[]{l + 1, r + 1};
        }

        return null;
    }
}
