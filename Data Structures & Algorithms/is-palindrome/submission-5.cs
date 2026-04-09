public class Solution {
    public bool IsPalindrome(string s) {
        s = new string(s.ToCharArray().Select(c => Char.ToLower(c)).Where(c => Char.IsLetterOrDigit(c)).ToArray());

        var l = 0;
        var r = s.Length - 1;

        while(l < r)
        {
            if(s[l] != s[r])
                return false;
            
            l++;
            r--;
        }

        return true;
    }
}
