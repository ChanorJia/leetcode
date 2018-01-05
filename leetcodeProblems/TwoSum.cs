
using System.Collections.Generic;


public class TwoSumSolution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int resultX = 0;
        int resultY = 0;

        int count = nums.Length;
        for (int i = 0; i < count - 1; i++)
        {
            for (int j = i + 1; j < count; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    resultX = i;
                    resultY = j;
                    break;
                }
            }
        }

        int[] result = { resultX, resultY };

        return result;
    }

     public int[] TwoSum2(int[] nums, int target)
    {
        int resultX = 0;
        int resultY = 0;

        int count = nums.Length;
        Dictionary<int,int> _tempDic=new Dictionary<int,int>();

        for (int i = 0; i < count ; i++)
        {
            if(_tempDic.ContainsKey(target-nums[i]))
            {
                resultX=i;
                _tempDic.TryGetValue((target-nums[i]),out resultY);
                break;
            }
            else
                _tempDic.Add(nums[i],i);
            
        }

        int[] result = { resultX, resultY };

        return result;
    }
}
