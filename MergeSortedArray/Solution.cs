namespace MergeSortedArray
{
    public class Solution
    {
        /*
         * Psuedo code:
         * 1) Initialize a variable `lastElement` to `m` + `n` - 1
         * 2) Loop while `m` and `n` are greater than 0
         * 3) If the element at `nums1[m - 1]` is greater than the element at `nums2[n - 1]`, set the element at `nums1[lastElement]` to `nums1[m - 1]` and decrement `m`
         * 4) Otherwise, set the element at `nums1[lastElement]` to `nums2[n - 1]` and decrement `n`
         * 5) Decrement `lastElement`
         * 6) Loop while `n` is greater than 0
         * 7) Set the element at `nums1[lastElement]` to `nums2[n - 1]` and decrement `n` and `lastElement`
         */
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            var lastElement = m + n - 1;

            while (m > 0 && n > 0)
            {
                if (nums1[m - 1] > nums2[n - 1])
                {
                    nums1[lastElement] = nums1[m - 1];
                    m--;
                }
                else
                {
                    nums1[lastElement] = nums2[n - 1];
                    n--;
                }

                lastElement--;
            }

            while (n > 0)
            {
                nums1[lastElement] = nums2[n - 1];
                n--;
                lastElement--;
            }
        }
    }
}
