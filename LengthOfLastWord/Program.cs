using LengthOfLastWord;

/*
 * Problem Statement:
 * Given a string `s` consisting of words and spaces, return the length of the last word in the string.
 * A word is a maximal substring consisting of non-space characters only.
 */

var s = "   Hello  World   ";

var solution = new Solution();

Console.WriteLine(solution.LengthOfLastWord(s)); // Output: 5