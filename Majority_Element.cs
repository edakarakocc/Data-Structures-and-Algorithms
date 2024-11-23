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

