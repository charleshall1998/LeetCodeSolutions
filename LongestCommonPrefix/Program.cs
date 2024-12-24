using LongestCommonPrefix;

/**
 * Problem Statement:
 * Write a function to find the longest common prefix string amongst an array of strings.
 * If there is no common prefix, return an empty string "".
 */
var strs = new string[] { "flower", "flow", "flight" };

//Correct Answer: "fl"

var solution = new Solution();

var result = solution.LongestCommonPrefix(strs);

Console.WriteLine(result);