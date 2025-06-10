public class MagicDictionary {
    Dictionary<string, string> dict; 
    public MagicDictionary() {
        dict = new Dictionary<string, string>();
    }
    
    public void BuildDict(string[] dictionary) {
        for (int i = 0; i < dictionary.Length  ; i++)
        {
            dict.Add(dictionary[i], dictionary[dictionary.Length - 1 ]);
        }
    }

    public bool Search(string searchWord)
    {
        // if (dict.ContainsKey(searchWord))
        // {
        //     return false;
        // }
        foreach (var item in dict)
        {
            int diff = 0;
            if (item.Key.Length != searchWord.Length)
            {
                continue;
            }
            else
            {
                for (int i = 0; i < searchWord.Length; i++)
                {
                    if (searchWord[i] != item.Key[i])
                    {
                        diff++;
                        if (diff > 1) break;
                    }
                }
            }
            if (diff == 1) return true;
        }
        return false;
        
    }
}
