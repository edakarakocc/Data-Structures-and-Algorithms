// O(n^2) / O(1)
internal class Program
{
    private static void Main(string[] args)
    {
        List<int> nums = new List<int> { 1, 1, 2, 3, 3, 5, 5, 5, 5, 5, 5 };
        int majority_element = 0;

        for(int i = 0; i < nums.Count; i++)
        {
            int count = 0;
            for(int j = 0; j < nums.Count; j++)
            {
                if (nums[i] == nums[j])
                {
                    count++;
                }

                if (count >= nums.Count / 2)
                {
                    majority_element = nums[i];
                    break;
                }
            }
        }
        Console.WriteLine(majority_element);
        Console.ReadKey();
    }
}



/* O(n) / O(n)
 * 
 * internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<int, int> nums = new Dictionary<int, int> { { 1, 1 }, { 5, 1 }, { 2, 6 }, { 3, 3 } }; // {key,value} ; the key represents the number, and the value represents its quantity.
        int max_value = 0;
        var majority = 0;

        foreach(var key in nums)
        {
            if (key.Value > max_value)
            {
                max_value = key.Value;
                majority = key.Key;
            }
        }
        Console.WriteLine(majority);
        Console.ReadKey();
    }
}*/




/* O(n) / O(n)  This shows a different approach to using a dictionary.
 * 
 * internal class Program
{
    private static void Main(string[] args)
    {
        List<int> nums = new List<int> { 1, 1, 2, 3, 3, 5, 5, 5, 5, 5, 5 };
        Dictionary<int, int> numbers = new Dictionary<int, int> {};
        int max_repeat = 0;
        int maxValue = 0;

        foreach(int num in nums)
        {
            if (numbers.ContainsKey(num))
                numbers[num] += 1;
            else
                numbers[num] = 1;

            if (numbers[num] > max_repeat)
            {
                max_repeat = numbers[num];
                maxValue = num;
            }
        }
        Console.WriteLine(maxValue);
        Console.ReadKey();
    }
}*/
