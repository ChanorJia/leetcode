using System;

namespace leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            longsetPalindromicSub ss=new longsetPalindromicSub();
            Console.WriteLine(ss.LongestPalindrome("babad"));  //bab
            Console.WriteLine(ss.LongestPalindrome("cbbd"));   //bb
            Console.WriteLine(ss.LongestPalindrome("a"));     //a
            Console.WriteLine(ss.LongestPalindrome("ccc"));   //ccc
            Console.WriteLine(ss.LongestPalindrome("bb"));    ///bb
            Console.WriteLine(ss.LongestPalindrome("abcba"));  //abcba
            Console.WriteLine(ss.LongestPalindrome("babadada"));   //"adada"
            Console.WriteLine(ss.LongestPalindrome("sooos"));
            // test test=new test();
            // test.aaa();



            // Console.WriteLine("Hello World!");
            // TwoSumSolution twoSumSolution=new TwoSumSolution();
            // Console.WriteLine(twoSumSolution.TwoSum(new int[]{2,3,5,7,7},6));
        }
    }
}
