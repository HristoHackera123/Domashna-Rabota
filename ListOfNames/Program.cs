namespace ListOfNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            for (int i = 0; i < names.Count; i++)
            {
                Console.Write($"{names[i]}");
                if (names.Count - i != 1)
                {
                    Console.Write("; ");
                }
            }
        }
    }
}
