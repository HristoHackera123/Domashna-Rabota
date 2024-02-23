namespace RemoveNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int id = numbers[numbers.Count - 1];
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    if (numbers[i] == id)
            //    {
            //        numbers.Remove(numbers[i]);
            //    }
            //}
            //-------------------------------------
            ////foreach (int number in numbers)
            ////{
            ////    if (numbers[number] == id)
            ////    {                                NE GO PRAVI TAKA
            ////        numbers.RemoveAt(number);
            ////    }
            ////}
            //-------------------------------------
            //while (numbers.Contains(id))
            //{
            //    numbers.Remove(id);
            //}
            Console.WriteLine($"Proceeding to delete all {id}");
            int index;
            while ((index = numbers.IndexOf(id)) != -1)
            {
                Console.WriteLine($"Removed number at position #{index+1}");
                numbers.Remove(id);
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
