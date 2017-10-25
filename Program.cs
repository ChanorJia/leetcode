using System;

namespace leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            object ss=1%2;
            // test test=new test();
            // test.aaa();
            Console.WriteLine("Hello World!");
            TwoSumSolution twoSumSolution=new TwoSumSolution();
            Console.WriteLine(twoSumSolution.TwoSum(new int[]{2,3,5,7,7},6));
        }
    }
}
