public class Solution {
    public bool IsPalindrome(string s) {
        s = new string(s.ToCharArray()
        .Where(c => !Char.IsWhiteSpace(c) && char.IsLetterOrDigit(c))
        .ToArray());

        var pointer = s.Length - 1;

        for(int i = 0; i < s.Length; i++)
        {
            if(char.ToLower(s[i]) != char.ToLower(s[pointer]))
            {
                return false;
            }
                

            pointer--;
            if(pointer == i) break;
        }

        return true;
    }
}
