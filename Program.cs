using System.Linq;

namespace LibraryGroup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen!");

            //Vi skapar biblioteket
            Library library = new Library();

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
                        Console.WriteLine("Vad heter boken?");
                        string title = Console.ReadLine();

                        Console.WriteLine("Vad heter författaren?");
                        string author = Console.ReadLine();

                        Console.WriteLine("Vad har den för ISBN?");
                        string isbn = Console.ReadLine();

                        library.CreateBook(title, author, isbn);

                        Console.WriteLine("Boken är nu tillagd!");
                        //Ge lite väntetid för effekt
                        Thread.Sleep(1000);
                        break;

                    case "2":
                        Console.WriteLine("Ange titel på den bok du vill ta bort från biblioteket: ");
                        string bookToRemove = Console.ReadLine();
                        library.RemoveBook(bookToRemove);
                        Thread.Sleep(1000);//Ge lite väntetid för effekt
                        break;
                    case "3":
                        Console.WriteLine("Ange bokens författare");
                        string userSearchAuthor = Console.ReadLine();
                        List<Book> foundBook = library.SearchBookByAuthor(userSearchAuthor);
                        if (foundBook != null)
                        {
                            foreach (Book book in foundBook)
                            {
                                Console.Write("Följande bok matchade din sökning - ");
                                Console.WriteLine($"Titel: {book.Title}, Författare: {book.Author}, ISBN: {book.ISBN}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ingen bok matchade din sökning");
                        }
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