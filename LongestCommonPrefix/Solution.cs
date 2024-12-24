namespace LongestCommonPrefix
{
    public class Solution
    {
        /**
         * Pseudo Code:
         * 1) Set the first string in the array to the longest common prefix (LCP)
         * 2) Iterate over `strs`
         * 3) Check if LCP is contained in the string
         * 4) If yes, LCP will remain the same. Continue iteration.
         * 5) Else, remove the last letter from LCP until true.
         */
        public string LongestCommonPrefix(string[] strs)
        {
            var lcp = strs[0];

            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(lcp) != 0)
                {
                    lcp = lcp.Substring(0, lcp.Length - 1);
                }
            }

            return lcp;
        }
    }
}
