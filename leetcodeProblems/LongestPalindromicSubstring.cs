/* Given a string s, find the longest palindromic substring in s. You may assume that the maximum length of s is 1000.

Example:

Input: "babad"

Output: "bab"

Note: "aba" is also a valid answer.

Example:

Input: "cbbd"

Output: "bb" */
using System.Collections.Generic;
using System.Text;

public class longsetPalindromicSub
{
    public string LongestPalindrome(string s)
    {
        Dictionary<string,int> letterDic=new Dictionary<string, int>();
        
        int finalStartIndx=0;
        int finalLen=1;

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
                    startIndx=0;
                    len=1;

                    if(len-1<=(i-repeatIndx))
                    {
                        len=i-repeatIndx+1;
                        startIndx=repeatIndx;
                    }

                     //向右扩展 //单向向左的情况不存在因为是DIctionary

                    bool isallsame=true;
                    for (int p = startIndx; p <= i ; p++)
                    {
                        if (curretnLetter != s.Substring(p, 1))
                        {
                            isallsame = false;
                        }
                    }

                    for (int k = i + 1; k < s.Length; k++)
                    {
                       

                        if (curretnLetter == s.Substring(k, 1) && isallsame)
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

                    //左右扩展 在更新的startindx和len的基础上
                    repeatIndx=startIndx;
                    int j=i;
                    i=startIndx+len-1;    //len包含第一个自身

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

                   i=j;

                   
                     if(len>=finalLen)
                    {
                        finalLen=len;
                        finalStartIndx=startIndx;
                    }
                }
              
                letterDic.Remove(curretnLetter);
                letterDic.Add(curretnLetter,i);             
            }
            else
                letterDic.Add(curretnLetter,i);    
            
        }


        return s.Substring(finalStartIndx,finalLen);
    }

    public bool IsPalindrome(int x)
    {
        StringBuilder sb = new StringBuilder(x.ToString());

        int centerCount = 0;
        if (isOddNumber(sb.Length))
        {
            centerCount = 1;
        }
        else
        {
            centerCount = 0;
        }


        int i = 0;
        int j = sb.Length - 1;
        int count = (sb.Length - centerCount) / 2;

        for (int k = 0; k < count; k++)
        {
            if (sb[i + k] != sb[j - k])
                return false;
        }

        return true;
    }

    bool isOddNumber(int n)
    {
        return (n & 1) == 1;
    }

}