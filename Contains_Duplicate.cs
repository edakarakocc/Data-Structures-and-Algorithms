// O(n^2)
internal class Program
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



/* O(n)
 * using System;
using System.Collections.Generic;

namespace Data_Structures_and_Algorithms
{
    internal class Contains_Duplicate
    {
        private static void Main(string[] args)
        {
            List<int> nums = new List<int> { 1, 2, 3, 4, 5, 1, 2 };
            HashSet<int> uniqueNumbers = new HashSet<int>();
            bool hasDuplicated = false;

            foreach (int num in nums)
            {
                if (!uniqueNumbers.Add(num))
                {
                    hasDuplicated = true;
                    break;
                }
            }
            Console.WriteLine(hasDuplicated);
            Console.ReadKey();
        }
    }
}*/
