namespace LeetCode_Solutions;

public partial class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        return [GetDistinctNumbers(nums1, nums2), GetDistinctNumbers(nums2, nums1)];
    }

    private IList<int> GetDistinctNumbers(int[] arr1, int[] arr2) {
        var numbersOnlyPresentInArr1 = new HashSet<int>();

        for (var i = 0; i < arr1.Length; i++)
            numbersOnlyPresentInArr1.Add(arr1[i]);

        for (var i = 0; i < arr2.Length; i++)
            numbersOnlyPresentInArr1.Remove(arr2[i]);

        return numbersOnlyPresentInArr1.ToList();
    }
}