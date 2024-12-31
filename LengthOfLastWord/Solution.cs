namespace LengthOfLastWord
{
    public class Solution
    {
        /*
         * Psuedo code:
         * 1) Initialize a variable `lastWordLength` to 0
         * 2) Initialize a pointer variable `p` to the length of the string - 1
         * 3) Loop through the string from the end to the beginning
         * 4) If the character at the current index is a space, decrement `p`
         * 5) If the character at the current index is not a space, increment `lastWordLength` and decrement `p`
         * 6) Return `lastWordLength`
         */
        public int LengthOfLastWord(string s)
        {
            int lastWordLength = 0;

            int p = s.Length - 1;

            while (s[p] == ' ')
            {
                p--;
            }

            while (p >= 0 && s[p] != ' ')
            {
                lastWordLength++;
                p--;
            }

            return lastWordLength;
        }
    }
}
