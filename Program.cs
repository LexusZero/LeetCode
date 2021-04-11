using System;

namespace LeetCode
{
    class Program
    {   // Problem Two Sum
        // https://leetcode.com/problems/two-sum/
        static void Main(string[] args)
        {
            Console.WriteLine("Input Length");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Input Number");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Input Target");
            int target = Convert.ToInt32(Console.ReadLine());
            Solution output = new Solution();
            Console.WriteLine(output.TwoSum(array, target));

        }

        public class Solution
        {
            public int[] TwoSum(int[] nums, int target)
            {
                int[] output = new int[2];
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        int sum = nums[i] + nums[j];
                        if (sum == target)
                        {
                            output[0] = i;
                            output[1] = j;
                            return output;
                        }
                    }
                }
                return new int[0];
            }
        }
    }
}

