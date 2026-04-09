public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        var shortestWordLength = int.MaxValue;
        foreach (var str in strs)
            shortestWordLength = Math.Min(shortestWordLength, str.Length);

        var prefixArr = new char[shortestWordLength];
        var j = 0;

        while (j < shortestWordLength)
        {
            var targetChar = strs[0][j];

            for (int i = 1; i < strs.Length; i++)
            {
                if (strs[i][j] != targetChar)
                    return new string(prefixArr, 0, j);
            }

            prefixArr[j] = targetChar;
            j++;
        }

        return new string(prefixArr, 0, j);
    }
}