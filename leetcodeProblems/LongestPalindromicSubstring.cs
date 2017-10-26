/* Given a string s, find the longest palindromic substring in s. You may assume that the maximum length of s is 1000.

Example:

Input: "babad"

Output: "bab"

Note: "aba" is also a valid answer.

Example:

Input: "cbbd"

Output: "bb" */
using System.Collections.Generic;

public class longsetPalindromicSub
{
    public string LongestPalindrome(string s)
    {
        Dictionary<string,int> letterDic=new Dictionary<string, int>();
        
        int startIndx=0;
        int len=1;
        
        for(int i=0;i<s.Length;i++)
        {
            string curretnLetter=s.Substring(i,1);
            if(letterDic.ContainsKey(curretnLetter))
            {
                int repeatIndx=-1;
                letterDic.TryGetValue(curretnLetter,out repeatIndx);
               
                if((i-repeatIndx)==1||(i-repeatIndx)==2)
                {
                    if(len<=(i-repeatIndx))
                    {
                        len=i-repeatIndx+1;
                        startIndx=repeatIndx;
                    }
                    //左右扩展 
                    int cirCount=repeatIndx>(s.Length-i)?(s.Length-i):repeatIndx;

                    for(int g=1;g<=cirCount;g++)   //从0开始 判断自身是否相等
                    {
                        if (repeatIndx - g > -1 && (i + g) < s.Length)
                        {
                            if (s.Substring(repeatIndx - g, 1) == s.Substring(i + g, 1))
                            {
                                if ((i + 2 * g - repeatIndx) >= len)
                                {
                                    len = i + 2 * g - repeatIndx + 1;
                                    startIndx = repeatIndx - g;
                                }
                            }
                            else
                                break;
                        }
                    }

                    //向右扩展
                    for(int k=i+1;k<s.Length;k++)
                    {
                        if (curretnLetter == s.Substring(k, 1))
                        {
                            if (k - repeatIndx >= len)
                            {
                                len = k - repeatIndx + 1;
                                startIndx = repeatIndx;
                            }
                        }
                        else
                            break;
                    }

                }
              
                letterDic.Remove(curretnLetter);
                letterDic.Add(curretnLetter,i);             
            }
            else
                letterDic.Add(curretnLetter,i);    
            
        }


        return s.Substring(startIndx,len);
    }
}