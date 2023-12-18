using System;
using System.Linq;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 4,2,5,9,7,4,8};
            Array.Sort(nums);
            int num = nums.Length;
            int maximum = (nums[num - 1] * nums [num - 2]) - (nums[0] * nums[1]);

            Console.WriteLine(maximum);
        }
    }
}