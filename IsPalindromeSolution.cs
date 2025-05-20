namespace neetCode
{
    internal class IsPalindromeSolution
    {
        public bool IsPalindrome(string s)
        {
            char[] chars = s.ToCharArray();
            int left = 0;
            int right = chars.Length - 1;

            while (left < right)
            {
                while(left < right && !char.IsLetter(chars[left])) left++;
                while(left < right && !char.IsLetter(chars[right])) right--;

                if (left < right)
                {
                    if(char.ToLower(chars[left]) != char.ToLower(chars[right])) return false;

                    left++;
                    right--;
                }
            }
            return true;
            
        }
    }
}
