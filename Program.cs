namespace LibraryGroup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Books> bokLista = new List<Books>();

            Console.WriteLine("Välkommen!");

            bool running = true;
            while (running) { 

                Console.WriteLine("1. Lägg till en bok");
                Console.WriteLine("2. Ta bort en bok");
                Console.WriteLine("3. Sök efter en bok enligt författare");
                Console.WriteLine("4. Visa alla böcker");
                Console.WriteLine("5. Checka ut/returnera bok");
                Console.WriteLine("6. Avsluta");

                string input = Console.ReadLine();
                switch (input) {

                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Jag förstår inte");
                        break;
            
                }

            }
        }
    }
}
