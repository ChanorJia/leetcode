using System.Collections.Generic;

public class MedianSortedArrays
{
      public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
           double result = 0;

            List<int> finalArrays = new List<int>();

            int n1=0,n2 = 0;         

          
            while (n1 < nums1.Length && n2 < nums2.Length)
            {
                if (nums1[n1] > nums2[n2])
                {
                    finalArrays.Add(nums2[n2++]);
                }
                else if (nums1[n1] < nums2[n2])
                {
                    finalArrays.Add(nums1[n1++]);
                }
                  else if (nums1[n1] == nums2[n2])
                {
                      finalArrays.Add(nums1[n1++]);
                      finalArrays.Add(nums2[n2++]);
                }
            }

            if (n2==nums2.Length)
            {
                while (n1 < nums1.Length)
                    finalArrays.Add(nums1[n1++]);
            }
            else if (n1==nums1.Length)
            {
                while (n2 < nums2.Length)
                    finalArrays.Add(nums2[n2++]);
            }

            if (finalArrays.Count % 2 == 0)
            {
                result = (double)(finalArrays[finalArrays.Count / 2] + finalArrays[finalArrays.Count / 2 - 1]) / 2;
            }
            else if (finalArrays.Count % 2 == 1)
            {
                result = finalArrays[finalArrays.Count / 2];
            }

            return result;
    }
}