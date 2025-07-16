public class Solution {
    public bool IsValid(string word)
    {
        if (word.Length < 3) return false;
        bool vowel = false;
        bool notvowel = false;

        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == '@' || word[i] == '#' || word[i] == '$')
            {
                return false;
            }
            if (word[i] == 'a' || word[i] == 'o' || word[i] == 'e' || word[i] == 'i' || word[i] == 'u' || word[i] == 'A' || word[i] == 'O' || word[i] == 'E' || word[i] == 'I' || word[i] == 'U')
            {
                vowel = true;
            }
            else if ((int)word[i] >= 65 && (int)word[i] <= 122)
            {
                notvowel = true;
            }

        }
        if (vowel && notvowel)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}