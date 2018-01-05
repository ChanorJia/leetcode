



public class RegularExpressionMatching {
    public bool IsMatch(string s, string p) {
        const string singleStr = ".";
        const string multiStr = "*";

        bool result = false;

        int i = 0, j = 0;
        string subpattern="";
        string subStr="";

        while (i < s.Length  || j < p.Length )
        {
            try
            {
                subpattern = p.Substring(j, 1);
                subStr = s.Substring(i, 1);
            }
            catch
            {
                result = false;
                break;
            }

            if (subpattern == multiStr)
            {
                string lastLetter = p.Substring(j - 1, 1);

                while(i<s.Length&&(s.Substring(i,1)==lastLetter||s.Substring(i,1)==singleStr))
                {
                    i++;
                }         
            }
            else if (subpattern != subStr&&subpattern!=singleStr)
            {
                if(p.Substring(j+1,1)==multiStr)
                     continue;
                     
                result = false;
                break;
            }

            result = true;         
            i++;
            j++;
        }

        return result;
    }


}