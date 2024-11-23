internal class Program
{
    private static void Main(string[] args)
    {
        List<int> nums = new List<int> { 2, 2, 5, 3, 4, 4, 3, 5, 9 };

        for(int i = 0; i < nums.Count; i++)
        {
            int count = 0;

            for(int j = 0; j < nums.Count; j++)
            {
                if (nums[i] == nums[j])
                {
                    count++;
                }

            }

            if (count == 1)
            {
                Console.WriteLine(nums[i]);
                break;
            }
        }

        Console.ReadKey();

    }
}