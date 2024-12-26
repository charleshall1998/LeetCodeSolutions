/*
 * Given an integer array `nums` and an integer `val`, remove all occurrences of `val` in `nums` in-place.
 * The order of the elements may be changed.
 * Then return the number of elements in `nums` which are not equal to `val`.
 */

using RemoveElement;

var nums = new int[] { 3, 2, 2, 3 };

var val = 3;

var solution = new Solution();

var result = solution.RemoveElement(nums, val);

Console.WriteLine(result); // Output: 2