// write a program in c# to get the minimum difference for the array [4,9,15,8]

using System;

public class Program
{
    public static void Main()
    {
        int[] nums = { 4, 9, 15, 8 };

        // Sort the array
        Array.Sort(nums);

        // Initialize minDiff with a large value
        int minDiff = int.MaxValue;

        // Iterate through the array to find minimum difference
        for (int i = 1; i < nums.Length; i++)
        {
            int diff = nums[i] - nums[i - 1];
            if (diff < minDiff)
            {
                minDiff = diff;
            }
        }

        Console.WriteLine("Minimum difference in the array: " + minDiff);
    }
}


//OutPut:
//Minimum difference in the array: 1
