﻿using System;

namespace leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass test=new TestClass();

         

            // test.TestReverse();
            // test.TestPalindromeInt();
            test.TestRegularExpression();
        }
    }

    public class TestClass
    {
        public void TestRegularExpression()
        {
            RegularExpressionMatching m=new RegularExpressionMatching();
            Console.WriteLine(1);
            Console.WriteLine(m.IsMatch("aa","a")==false);
            Console.WriteLine(2);
            Console.WriteLine(m.IsMatch("aa","aa")==true);
            Console.WriteLine(3);
            Console.WriteLine(m.IsMatch("aaa","aa")==false);
            Console.WriteLine(4);
            Console.WriteLine(m.IsMatch("aa","a*")==true);
            Console.WriteLine(5);
            Console.WriteLine(m.IsMatch("aa",".*")==true);
            Console.WriteLine(6);
            Console.WriteLine(m.IsMatch("ab",".*")==true);
            Console.WriteLine(7);
            Console.WriteLine(m.IsMatch("aab","c*a*b")==true);


            Console.WriteLine(8);
            Console.WriteLine(m.IsMatch("aaba","ab*a*c*a")==false);

            Console.WriteLine(9);
            Console.WriteLine(m.IsMatch("aaa","a*a")==true);

            Console.WriteLine(10);
            Console.WriteLine(m.IsMatch("aaa",".a")==false);

            Console.WriteLine(11);
            Console.WriteLine(m.IsMatch("aaa","ab*a*c*a")==true);


            Console.WriteLine(12);
            Console.WriteLine(m.IsMatch("aaa","ab*a")==false);

            Console.WriteLine(13);
            Console.WriteLine(m.IsMatch("a","ab*a")==false);

            Console.WriteLine(14);
            Console.WriteLine(m.IsMatch("a","ab*")==true);

          
            Console.WriteLine(15);
            Console.WriteLine(m.IsMatch("a",".*..a*")==false);

            Console.WriteLine(16);
            Console.WriteLine(m.IsMatch("aaa","a.a")==true);
          
            Console.WriteLine(17);
            Console.WriteLine(m.IsMatch("aaca","ab*a*c*a")==true);

         
            Console.WriteLine(18);
            Console.WriteLine(m.IsMatch("ab",".*..")==true);
        }

        public void TestPalindromeInt()
        {
            longsetPalindromicSub l=new longsetPalindromicSub();
            Console.WriteLine(l.IsPalindrome(231));
            Console.WriteLine(l.IsPalindrome(232));
            Console.WriteLine(l.IsPalindrome(0));
            Console.WriteLine(l.IsPalindrome(12));
            Console.WriteLine(l.IsPalindrome(2345432));
        }
        public void TestReverse()
        {
            ReverseInteger re=new ReverseInteger();
            Console.WriteLine(re.Reverse(231)==132);
            Console.WriteLine(re.Reverse(-231)==-132);
            Console.WriteLine(re.Reverse(120)==21);
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

        public void TestTwoSum()
        {
            TwoSumSolution twoSumSolution=new TwoSumSolution();
            int[] cc=twoSumSolution.TwoSum2(new int[]{2,3,5,7,7},8);
            Console.WriteLine(cc[0]);
            Console.WriteLine(cc[1]);

            cc=twoSumSolution.TwoSum2(new int[]{3,2,4},6);
            Console.WriteLine(cc[0]);
            Console.WriteLine(cc[1]);
        }

        void TestYouyu()
        {
            // test test=new test();
            // test.aaa();
        }
    }
}
