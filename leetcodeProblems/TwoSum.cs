
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
}
