public class Solution {

    public string Encode(IList<string> strs) {
        var builder = new StringBuilder();
        foreach(var str in strs)
        {
            builder.Append(str + ";");
        }
        return builder.ToString();
    }

    public List<string> Decode(string s) {
        var res = new List<string>();

        var builder = new StringBuilder();
        foreach(var c in s)
        {
            if(c != ';')
            {
                builder.Append(c);
            }
            else{
                res.Add(builder.ToString());
                builder.Clear();
            }
        }
        return res;
   }
}
