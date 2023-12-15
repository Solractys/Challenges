using System;
class Program
{

    public class Solution
    {
        public int[] nums = [2, 7, 11, 5];
        public int target = 9;

        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int cur = nums[i];
                int x = target - cur;

                if (map.ContainsKey(x))
                {
                    return new int[] { map[x], i };
                }
                map[cur] = i;
            }
            return null;
        }
    }
    static void Main(string[] args)
    {

    }
}