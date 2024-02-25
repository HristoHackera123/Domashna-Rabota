namespace MergeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write some lists to merge, with \'|\' in between WITHOUT spaces");
            List<string> input = Console.ReadLine().Split("|").ToList();
            input.Reverse();
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
