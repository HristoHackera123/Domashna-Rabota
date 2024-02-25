using System.Globalization;

namespace AllahuAkbar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> bombfield = Console.ReadLine().Split().Select(int.Parse).ToList();
            Console.Write("Enter bomb number and its force: ");
            int[] info = new int[2];
            info = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bomb = info[0];
            int force = info[1];

            List<int> survivors = new List<int>();
            int bombIndex = bombfield.IndexOf(bomb);
            bool bombLife = false;

            for (int i = 0; i < bombfield.Count; i++)
            {
                if (i < bombIndex - force || i > bombIndex + force)
                {
                    survivors.Add(bombfield[i]);
                    if (bombfield[i] == bomb)
                    {
                        bombLife = true;
                    }
                }

                if (bombfield[i] == bomb && bombLife)
                {
                    bomb = bombfield[i];
                    bombIndex = i;
                    for (int j = i; j >= i - force; j--)
                    {
                        if (survivors.Contains(bombfield[j]))
                        {
                            survivors.Remove(bombfield[j]);
                        }
                    }
                }
            }
            int sum = 0;
            for (int i = 0;i < survivors.Count; i++)
            {
                sum += survivors[i];
            }
            Console.WriteLine($"The survivors are: {string.Join(" ", survivors)}");
            Console.WriteLine($"Their sum is {sum}");
        }
    }
}
