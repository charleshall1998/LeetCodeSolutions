namespace RomanToInteger
{
    public class Solution
    {
        /**
         * Psuedo Code:
         * 1) Create a dictionary to map roman characters to integers
         * 2) Initialize a variable to store the result
         * 3) Iterate through the string
         * 4) If the current character is less than the next character, subtract the current character from the result
         * 5) Otherwise, add the current character to the result
         * 6) Return the result
         */
        public int RomanToInt(string s)
        {
            Dictionary<char, int> romanToInt = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            var toReturn = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i != s.Length - 1 && romanToInt[s[i + 1]] > romanToInt[s[i]])
                {
                    toReturn -= romanToInt[s[i]];
                }
                else
                {
                    toReturn += romanToInt[s[i]];
                }
            }

            return toReturn;
        }
    }
}
