namespace neetCode
{
    internal class EncodeAndDecodeStrings
    {
        int key = 2;
        List<int> lengthEncodedWords = new();
        

        public string Encode(IList<string> strs)
        {

            string s = "";
            foreach (string word in strs)
            {
                int length = 0;
                for (int i = 0; i <= word.Length - 1; i++)
                {
                    s += (char)(word[i] + key);
                    length++;
                }
                lengthEncodedWords.Add(length);
            }
            return s;
        }

        public List<string> Decode(string s)
        {
            List<string> decodedStrings = new();
            string newWord = "";
            int n = 0;
            int i = 0;
            foreach (char c in s)
            {
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
