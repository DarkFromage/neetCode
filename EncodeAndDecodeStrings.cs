namespace neetCode
{
    internal class EncodeAndDecodeStrings
    {
        int key = 2;
        List<int> lengthEncodedWords = new();
        
        public string Encode(IList<string> strs)
        {
            if (strs.Count == 0) return null;

            string s = "";
            foreach (string word in strs)
            {
                if (word.Length == 0)
                {
                    lengthEncodedWords.Add(0);
                }
                else
                {
                    int length = 0;
                    for (int i = 0; i <= word.Length - 1; i++)
                    {
                        s += (char)(word[i] + key);
                        length++;
                    }
                    lengthEncodedWords.Add(length);
                }
            }
            return s;
        }

        public List<string> Decode(string s)
        {
            if (s == null)
            {
                return new List<string>();
            }

            List<string> decodedStrings = new();

            if (s.Length == 0)
            {
                decodedStrings.Add("");
                return decodedStrings;
            }

            string newWord = "";
            int n = 0;
            int i = 0;
            foreach (char c in s)
            {
                if(lengthEncodedWords[n] == 0)
                {
                    decodedStrings.Add("");
                    n++;
                }
                newWord += (char)(c - key);
                i++;
                if (i == lengthEncodedWords[n])
                {
                    decodedStrings.Add(newWord);
                    newWord = "";
                    n++;
                    i = 0;
                }
            }
            lengthEncodedWords = new();
            return decodedStrings;
        }
    }
}
