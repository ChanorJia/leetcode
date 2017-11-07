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
using System;
using System.Collections.Generic;
using System.Text;

public class zigzag
{
    public string Convert(string s, int numRows)
    {
        List<string> col;
        List<List<string>> colLst=new List<List<string>>();

        int i=0;
        int currentColIndx=1;
        int lastFullcolIndx=-1;
        int ramins=numRows;

        if(numRows==1||s.Length<2)
            return s;

        while(i<s.Length)
        {
            ramins=s.Length-i<numRows?s.Length-i:numRows;
            col = new List<string>(numRows);

            if (currentColIndx ==lastFullcolIndx || currentColIndx == 1)
            {
                for (int j = 0; j < ramins; j++)
                {
                    col.Add(s.Substring((i + j), 1));
                }
                
                lastFullcolIndx=numRows-1+currentColIndx;
                colLst.Add(col);
                currentColIndx++;
            }
            else
            {
                for (int j = 1; j < ramins - 1; j++)
                {
                    col = new List<string>(numRows);
                    for (int c = 0; c < numRows; c++)
                    {
                        col.Add("");
                    }
                    col[numRows-j-1] = s.Substring((i + j), 1);
                    colLst.Add(col);

                    currentColIndx++;
                }
            }

            i += ramins - 1;
            
        }

        StringBuilder sb = new StringBuilder();

        for (int b = 0; b < numRows; b++)
        {
            for (int a = 0; a < colLst.Count; a++)
            {
                List<string> cc =colLst[a];
                
                if (b <= cc.Count - 1 && !string.IsNullOrWhiteSpace(cc[b]))
                {
                    sb.Append(cc[b].ToString().Trim());
                }
            }
        }
        return sb.ToString();
    }
}