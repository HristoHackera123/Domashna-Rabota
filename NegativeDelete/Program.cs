namespace NegativeDelete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] > 0)
                {
                    result.Add(nums[i]);
                }
            }
            if (result.Count == 0)
            {
                Console.WriteLine("Empty");
                return;
            }
            result.Reverse();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
