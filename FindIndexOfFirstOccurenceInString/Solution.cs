namespace FindIndexOfFirstOccurenceInString
{
    public class Solution
    {
        /*
         * Psuedo code:
         * 1) Loop through the haystack string from 0 to haystack.Length + 1 - needle.Length
         * 2) Loop through the needle string
         * 3) If the character at the current index of the haystack string is not equal to the character at the current index of the needle string, break
         * 4) If the loop completes, return the current index of the haystack string
         * 5) If the loop completes and no match is found, return -1
         */
        public int StrStr(string haystack, string needle)
        {
            for (int i = 0; i < haystack.Length + 1 - needle.Length; i++)
            {
                for (int j = 0; j < needle.Length; j++)
                {
                    if (haystack[i + j] != needle[j])
                    {
                        break;
                    }

                    if (j == needle.Length - 1)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
    }
}
