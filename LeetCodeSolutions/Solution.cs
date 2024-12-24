namespace PalindromeNumber
{
    public class Solution
    {

        /**
         * Pseudo Code:
         * 1) Create two pointers, one that starts from the beginng & another that starts from the end.
         * 2) Iterate over the number from the beginning and the end.
         * 3) If the characters at the two pointers are not equal, return false.
         * 4) Else, increment the first pointer and decrement the second pointer.
         * 5) If the loop completes, return true.
         */
        public bool IsPalindrome(int x)
        {
            var numString = x.ToString();
            var p1 = 0;
            var p2 = numString.Length - 1;

            while (p1 != p2 && p1 < numString.Length / 2)
            {
                if (numString[p1] != numString[p2])
                {
                    return false;
                }

                p1++;
                p2--;
            }

            return true;
        }
    }
}
