public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
    var res = new Dictionary<string,List<string>>();
    foreach( string s in strs){
    char[] charArray = s.ToCharArray();
    Array.Sort(charArray);
    string sSorted = new string(charArray);
    if(! res.ContainsKey(sSorted)){
    res[sSorted] = new List<string>();}
    res[sSorted].Add(s);
    }
        return res.Values.ToList<List<string>>();
    }
}
