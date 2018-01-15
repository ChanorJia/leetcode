

using System.Collections.Generic;

public class RegularExpressionMatching {

    const string singleStr = ".";
    const string multiStr = "*";
    const string connectStr = "-";

    public bool IsMatch(string s, string p) {
       
        bool result = true;
        string subpattern="";
        string subStr="";
        

        if(!p.Contains(singleStr)&&!p.Contains(multiStr))
        {
            return p.Equals(s);   //纯字母的
        }

        if (!p.Contains(multiStr))   //仅包含.的
        {
            if (p.Length != s.Length)
                return false;

            for (int k = 0; k < s.Length; k++)
            {
                subpattern = p.Substring(k, 1);
                subStr = s.Substring(k, 1);

                if(subStr!=subpattern&&subpattern != singleStr)
                {
                    return false;
                }
            }

            return true;
        }

        Dictionary<int,string> starStr=new Dictionary<int, string>();       
        bool isNextStart=false;

        int lastStartIndx=0;
        int i=0;
        int y=0;
        while(i<p.Length)
        {
            try
            {
                isNextStart = p.Substring(i + 1, 1) == multiStr;
            }
            catch
            {
                isNextStart=false;
            }

            if(isNextStart)   //带*号的pattern
            {
                starStr.Add(y++,p.Substring(i,1));
                
                string tempStr=p.Substring(lastStartIndx,i-lastStartIndx);            

                if(!string.IsNullOrWhiteSpace(tempStr))
                {
                    result=ProcessNotStarPart(tempStr,ref s);
                }
                
                lastStartIndx=i+2;
                i=i+2;
                continue;
            }
            else
            {
                string temp = p.Substring(i, p.Length - i);   //当前位到最后一位,包含当前位
                if (!temp.Contains(multiStr))                
                {
                    if (!string.IsNullOrWhiteSpace(temp))
                    {
                        result=ProcessNotStarPart(temp,ref s,false);
                    }

                    i=p.Length;
                }
            }
            i++;
        }

        if (!result)
            return result;

        string[] starArrays = s.Split(connectStr);
        int currentPatternIndx = 0;
        for (int c = 0; c < starArrays.Length; c++)
        {
            string tempItem = starArrays[c];
            if (!string.IsNullOrWhiteSpace(tempItem))
            {
                while (currentPatternIndx < starStr.Count)
                {
                    string letter = "";
                    starStr.TryGetValue(currentPatternIndx, out letter);
                    if (letter == singleStr)
                    {
                        starArrays[c] = "";
                        break;
                    }
                    if (string.IsNullOrWhiteSpace(tempItem.Replace(letter, "").Trim()))
                    {
                        starArrays[c] = "";
                        break;
                    }

                    if (tempItem.StartsWith(letter))
                        tempItem = tempItem.Replace(letter, "");

                    currentPatternIndx++;
                }
            }
        }

        foreach (string ss in starArrays)
        {
            if (!string.IsNullOrWhiteSpace(ss))
                result = false;
        }

        #region 老方法
        // //包含. 和*  或者包含 *
        // //* 一定出现在.或者字母后面
        // int i = 0, j = 0;
        // bool isNextStart=false;
        // while (i < s.Length  && j < p.Length )
        // {
        //     subpattern = p.Substring(j, 1);  //可能为. * 或者字母
        //     subStr = s.Substring(i, 1);

        //     //判断当前pattern下一位是否是*
        //     //超出界限也不是
        //     try
        //     {
        //         isNextStart = p.Substring(j + 1, 1) == multiStr;
        //     }
        //     catch
        //     {
        //         isNextStart = false;
        //     }


        //     if(subpattern==multiStr)
        //     {
        //         //s不动，p+1
        //         j++;
        //     }
        //     //. s和p均后移一位
        //     else if(subpattern==singleStr)
        //     {
        //         j++;
        //         i++;
        //     }
        //     //字母不相等  且 字母后面没有跟着*
        //     else if (!isNextStart && subStr != subpattern)
        //     {
        //         result = false;
        //         break;
        //     }
        //     //字母相等  且 字母后面没有跟着*
        //     else if (!isNextStart && subStr == subpattern)
        //     {
        //         j++;
        //         i++;
        //     }
        //     //字母相等 且 字母后面跟着* 
        //     else if (isNextStart && subStr == subpattern)
        //     {
        //         //* 后一个字母在s中出现的index 和当前 index之间的字母是否都一样
                

        //         j=j+2;
        //     }
        //     //字母不相等 且 字母后面跟着* 
        //     else if (isNextStart && subStr != subpattern)
        //     {
        //         //s不动 p 移动两位  pattern当前匹配为0
        //         j=j+2;
        //     }

            
        //     if (subpattern == multiStr)
        //     {
        //         string lastLetter = p.Substring(j - 1, 1);

        //         while (i < s.Length && (s.Substring(i, 1) == lastLetter || lastLetter == singleStr))
        //         {
        //             if (i == s.Length - 1)
        //                 break;
        //             i++;
        //         }
        //     }
        //     else if (subpattern != subStr && subpattern != singleStr)
        //     {
        //         if (j+1>p.Length-2|| p.Substring(j + 1, 1) != multiStr)
        //         {
        //             result = false;
        //             break;
        //         }            
        //     }
        //     else
        //     {
        //         if (j == p.Length - 1 && i < s.Length - 1)
        //         {
        //             result = false;
        //         }
        //         i++;              
        //     }
        //     j++;
        // }

        #endregion

        return result;
    }


    //处理不含*的部分
    bool ProcessNotStarPart(string str,ref string s,bool isfromstart=true)
    {
        string currentItem = str.Trim();
        if (s.Contains(currentItem))    //没有. 并且有完全相同的部分
        {
            int fIndx = -1;
            if (isfromstart)
                fIndx = s.IndexOf(currentItem);    //总是移除第一个符合的
            else
                fIndx = s.LastIndexOf(currentItem);

            s = s.Remove(fIndx, currentItem.Length);
            s = s.Insert(fIndx, connectStr);
        }
        else if (currentItem.Contains(singleStr))  //有点 的处理
        {
            string[] tt = currentItem.Split(singleStr);
            string ss = "";

            foreach (string strItem in tt)
            {
                if (!string.IsNullOrWhiteSpace(strItem))
                {
                    int fIndx = -1;

                    if (isfromstart)
                        fIndx = s.IndexOf(strItem);
                    else
                        fIndx = s.LastIndexOf(strItem);

                    if(fIndx<0)
                    {
                        return false;
                    }

                    

                    s = s.Remove(fIndx, currentItem.Length);
                    s = s.Insert(fIndx, connectStr);
                    
                }
                    ss = currentItem.Replace(strItem, "");
            }

            if (ss.Trim().Length == tt.Length - 1)
            {
                //currentItem replace后的长度和 split 后-1长度相等
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (!currentItem.Contains(singleStr))  //没有点，且不相同
        {
            return false;
        }

        return true;
    }
}