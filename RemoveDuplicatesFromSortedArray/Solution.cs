namespace RemoveDuplicatesFromSortedArray
{
    public class Solution
    {
        /**
         * Pseudo Code:
         * 1) Initialize left pointer
         * 2) Iterate over the array with right pointer
         * 3) If the current element is not equal to the previous element, then update the left pointer
         * 4) Update the left pointer with the current element
         * 5) Return the left pointer
         */
        public int RemoveDuplicates(int[] nums)
        {
            int l = 1;

            for (int r = 1; r < nums.Length; r++)
            {
                if (nums[r] != nums[r - 1])
                {
                    nums[l] = nums[r];
                    l++;
                }
            }

            return l;
        }
    }
}
