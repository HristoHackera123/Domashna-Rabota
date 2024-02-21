namespace ReverseSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sum = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                List<int> current = new List<int>();
                while (nums[i] > 0)
                {
                    current.Add(nums[i] % 10);
                    nums[i] = nums[i] / 10;
                }
                sum += int.Parse(string.Join("", current));
            }
            Console.WriteLine(sum);
        }
    }
}
