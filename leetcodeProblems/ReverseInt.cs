
using System.Text;

public class ReverseInteger
{
    public int Reverse(int x) {
        StringBuilder sb=new StringBuilder(x.ToString());

        StringBuilder resultSb=new StringBuilder();

        for(int i=sb.Length-1;i>0;i--)
        {
            resultSb.Append(sb[i]);
        }

        if(x==abs(x))
        {
            resultSb.Append(sb[0]);
        }
        else
        {
            resultSb.Insert(0,"-");
        }

        int result;

        int.TryParse(resultSb.ToString(),out result);

        return result;
    }


    int abs(int n)
    {  
        return (n ^ (n >> 31)) - (n >> 31);  
    }
}