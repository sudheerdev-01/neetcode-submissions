public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length!=t.Length){
            return false;
        }
        char[] s1 =s.ToCharArray();
        char[] t1 =t.ToCharArray();
        Array.Sort(s1);
        Array.Sort(t1);
        string s2 = new string(s1);
        string t2 = new string(t1);
        if(string.Equals(s2,t2)){
            return true;
        }
        return false;
    }
}
