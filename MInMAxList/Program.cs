namespace MInMAxList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int min = int.MaxValue; 
            int max = int.MinValue;
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
                if (nums[i] < min)
                {
                    min = nums[i];
                }
            }
            List<int> print = new List<int>();
            for (int i = 0;i < nums.Count;i++)
            {
                if (nums[i] == min)
                {
                    print.Insert(0, nums[i]);
                }
                else if (nums[i] == max)
                {
                    print.Add(nums[i]);
                }
            }
            Console.WriteLine(string.Join(" ", print));
        }
    }
}
