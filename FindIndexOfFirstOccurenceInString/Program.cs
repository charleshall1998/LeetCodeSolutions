using FindIndexOfFirstOccurenceInString;

/*
 * Problem Statement:
 * Given two strings `needle` and `haystack`, return the index of the first occurrence of `needle` in `haystack`, or -1 if `needle` is not part of `haystack`.
 */

var haystack = "sadbutsad";

var needle = "sad";

var solution = new Solution();

var result = solution.StrStr(haystack, needle);

Console.WriteLine(result); // Output: 0
