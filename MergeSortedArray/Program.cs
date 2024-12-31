using MergeSortedArray;

/*
 * You are given two integer arrays `nums1` and `nums2`, sorted in non-decreasing order, and two integers `m` and `n`, representing the number of elements in `nums1` and `nums2` respectively.
 * Merge `nums1` and `nums2` into a single array sorted in non-decreasing order.
 * The final sorted array should not be returned by the function, but instead be stored inside the array `nums1`.
 * To accommodate this, `nums1` has a length of `m` + `n`, where the first `m` elements denote the elements that should be merged, and the last `n` elements are set to 0 and should be ignored.
 * `nums2` has a length of `n`.
 */

var nums1 = new int[] { 1, 2, 3, 0, 0, 0 };

var nums2 = new int[] { 2, 5, 6 };

var m = 3;

var n = 3;

var solution = new Solution();

solution.Merge(nums1, m, nums2, n);

foreach (var num in nums1)
{
    Console.Write(num + " "); // Output: 1 2 2 3 5 6
}
