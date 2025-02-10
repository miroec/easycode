public class Solution {
    public bool DetectCapitalUse(string word) {
        if(word == word.ToUpper() || word == word.ToLower())
            return true;

        if(char.IsUpper(word[0]) && word.Substring(1) == word.Substring(1).ToLower())
            return true;
        else return false;
    }
}