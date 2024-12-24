using _1._TwoSum;

/**
 * Problem Statement:
 *
 * Given an array of integers `nums` and an integer `target`, return indices of the two numbers such that they add up to `target`.
 * You may assume that each input would have exactly one solution, and you may not use the same element twice.
 * You can return the answer in any order.
 */

var nums = new int[] { 2, 7, 11, 15 };
var target = 9;

//Correct answer: 0, 1

var solution = new Solution();

var result = solution.TwoSum(nums, target);

foreach (var value in result)
{
    Console.WriteLine(value);
}