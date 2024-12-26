namespace RemoveElement
{
    public class Solution
    {
        /**
         * 1) Initialize a variable to keep track of the non-val index
         * 2) Iterate over the array
         * 3) If the current element is not equal to the val, then update the non-val index
         * 4) Update the non-val index with the current element
         * 5) Return the non-val index
         */
        public int RemoveElement(int[] nums, int val)
        {
            var nonValIndex = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[nonValIndex] = nums[i];
                    nonValIndex++;
                }
            }

            return nonValIndex;
        }
    }
}
