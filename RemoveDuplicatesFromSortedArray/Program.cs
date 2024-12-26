

using RemoveDuplicatesFromSortedArray;

/**
 * Problem Statement:
 * Given an integer array `nums` sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once.
 * The relative order of the elements should be kept the same.
 * Then return the number of unique elements in nums.
 */
var nums = new int[] { 1, 1, 2 };

var solution = new Solution();

var result = solution.RemoveDuplicates(nums);

Console.WriteLine(result); // Output: 2