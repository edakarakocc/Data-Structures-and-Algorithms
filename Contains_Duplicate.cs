﻿internal class Program
{
    private static void Main(string[] args)
    {
        List<int> nums = new List<int> { 1, 2, 3, 4, 5, 1, 2 };
        bool hasDuplicated = false;

        for(int i = 0; i < nums.Count; i++)
        {
            for(int j = i + 1; j < nums.Count; j++)
            {
                if (nums[i] == nums[j])
                {
                    hasDuplicated = true;
                    break;
                }
            }
        }
        Console.WriteLine(hasDuplicated);
        Console.ReadKey();
    }
}