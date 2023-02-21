public class Solution {
    public bool IsValid(string s) {
        string open = "";
        foreach(char c in s) {
            if(c == '{' || c == '[' || c == '(') {
                open += c;
            }
            else {
                if(open.Length == 0) {
                    return false;
                }
                if(c == '}' && open[open.Length-1] != '{') {
                    return false;
                }
                else if(c == ']' && open[open.Length-1] != '[') {
                    return false;
                }
                else if(c == ')' && open[open.Length-1] != '(') {
                    return false;
                }
                else {
                    open = open.Remove(open.Length-1, 1);
                }
            }
        }
        if(open.Length == 0) {
            return true;
        }
        else {
            return false;
        }
    }
}