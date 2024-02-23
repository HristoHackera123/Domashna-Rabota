namespace ListCreate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете списък от зветове (done за край)");
            List<string> colorList = new List<string>();
            string? answer = Console.ReadLine();
            while (answer != "done")
            {
                colorList.Add(answer);
                answer = Console.ReadLine();
            }
            //for(int i = 0; i < colorList.Count; i++)
            //{
            //    Console.WriteLine(colorList[i]);
            //}
            foreach (string chervenokvadratcheobikaljashtoizspisuka in colorList)
            {
                Console.WriteLine(chervenokvadratcheobikaljashtoizspisuka);
            }

            Console.WriteLine($"Choose which element to delete (from 0-{colorList.Count - 1})");
            colorList.RemoveAt(int.Parse(Console.ReadLine()));

            foreach (string chervenokvadratcheobikaljashtoizspisuka in colorList)
            {
                Console.WriteLine(chervenokvadratcheobikaljashtoizspisuka);
            }
        }
    }
}
