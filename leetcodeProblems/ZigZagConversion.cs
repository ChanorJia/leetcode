/*
 The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: 
 (you may want to display this pattern in a fixed font for better legibility)

P   A   H   N
A P L S I I G
Y   I   R

And then read line by line: "PAHNAPLSIIGYIR"

Write the code that will take a string and make this conversion given a number of rows:

string convert(string text, int nRows);

convert("PAYPALISHIRING", 3) should return "PAHNAPLSIIGYIR". 
 */
using System.Collections.Generic;

public class zigzag
{
     public string Convert(string s, int numRows) {
        string result="";
        
     
        List<string> ss=new List<string>();
          List<string> final=new List<string>();

        string currentStr = "";
        string connect="-";
        for (int i = 0; i < s.Length; i++)
        {
            currentStr.PadRight(1,s.Substring(i,1).ToCharArray()[0]);
            currentStr.PadRight(1,connect.ToCharArray()[0]);
            if (i % numRows == 0)    //拐点 第一个拐点是 s[numRows]
            {
                 ss.Add(currentStr);
            }
        }

        for(int j=0;j<ss.Count;j++)
        {
            if(j>0&&j%2>0)
            {
                
            }
            else
                final.Add(ss[j]);
        }
        
       
        
        return result;
    }
}