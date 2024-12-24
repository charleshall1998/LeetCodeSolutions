namespace TwoSum;

public class Solution
{
    /**
     * Psuedo code:
     * 1) Iterate over `nums`
     * 2) Calculate the complement of the current element & the `target` (target - currentElement).
     * 3) Check if the dictionary contains the complement as a key.
     * 4) If it does, return the value of the key and the current index. Else, add a new record to the dictionary.
     * 5) Finally, if the complement does not exist at all, return empty array.
     */

    public int[] TwoSum(int[] nums, int target)
    {
        //Dictionary to store complements of each number in nums.
        var dictionary = new Dictionary<int, int>();

        //Iterate over nums
        for (int i = 0; i < nums.Length; i++)
        {
            //Get complement.
            var complement = target - nums[i];

            //Check if value of nums exists in dictionary
            if (dictionary.ContainsKey(complement))
            {
                return [dictionary[complement], i];
            }

            //Else, if DNE in dictionary, add it.
            if (!dictionary.ContainsKey(nums[i]))
            {
                dictionary.Add(nums[i], i);
            }
        }

        return [];
    }
}

