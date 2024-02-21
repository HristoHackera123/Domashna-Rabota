namespace ListOfNamesCompl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the names with a \', \' in between");
            List<string> names = Console.ReadLine().Split(", ").ToList();
            for (int i = 0; i < names.Count; i++)
            {
                List<string> current = names[i].Split().ToList();
                Console.WriteLine(current[1] + " " + current[0]);
            }
        }
    }
}
