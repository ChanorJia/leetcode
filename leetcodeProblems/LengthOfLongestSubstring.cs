using System;
using System.Collections.Generic;

public class LengthOfLongestSubstringSolution
{
  public int LengthOfLongestSubstring(string s) {
        int result = 0;

             int n = s.Length;

             HashSet<string> set = new HashSet<string>();
             int i = 0,j = 0;

             while(i<n&&j<n)
             {
                 if(!set.Contains(s.Substring(j,1)))
                 {
                     set.Add(s.Substring(j++, 1));
                     result = Math.Max(result,j-i);
                 }
                 else
                 { set.Remove(s.Substring(i++,1));}
             }

             return result;

    }
}