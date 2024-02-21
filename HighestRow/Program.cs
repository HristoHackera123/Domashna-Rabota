namespace HighestRow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string current = "";
            string best = "";
            for (int i = 0; i < nums.Count; i++)
            {
                if (i >= 1 && i < nums.Count - 1)
                {
                    if (nums[i] == nums[i - 1] || nums[i] == nums[i + 1])
                    {
                        current = $"{current} {nums[i]}";
                    }
                }
                if (current.Length > best.Length)
                {
                    best = current;
                }
                if (i < nums.Count - 1)
                {
                    if (nums[i + 1] != nums[i])
                    {
                        current = "";
                    }
                }
            }
            Console.WriteLine(best);
        }
    }
}
