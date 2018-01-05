using System;

namespace leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass test=new TestClass();
            test.TestReverse();
        }
    }

    public class TestClass
    {
        public void TestReverse()
        {
            ReverseInt ii=new ReverseInt();
            ii.Reverse(343);
        }

        public void TestzigzagConver()
        {
            zigzag zi=new zigzag();
            Console.WriteLine(zi.Convert2("PAYPALISHIRING", 3));
            Console.WriteLine(zi.Convert2("PAYPALISHIRING", 3)=="PAHNAPLSIIGYIR");
            Console.WriteLine(zi.Convert2("A", 1)=="A");
            Console.WriteLine(zi.Convert2("AB", 2)=="AB");
            Console.WriteLine(zi.Convert2("A", 2)=="A");
            Console.WriteLine(zi.Convert2("ABC", 2)=="ACB");
        }

        void TestLongestPalindrome()
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
            Console.WriteLine(ss.LongestPalindrome("ababababa"));      
            Console.WriteLine(ss.LongestPalindrome("aaabaaaa"));
        }

        void TestTwoSum()
        {
            TwoSumSolution twoSumSolution=new TwoSumSolution();
            Console.WriteLine(twoSumSolution.TwoSum(new int[]{2,3,5,7,7},6));
        }

        void TestYouyu()
        {
            // test test=new test();
            // test.aaa();
        }
    }
}
