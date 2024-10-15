using System;
using System.Linq;
using System.Threading;
using System.Collections.Generic;

namespace LibraryGroup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen!");

            // Vi skapar biblioteket
            Library library = new Library();

            bool running = true;
            while (running)
            {
                Console.WriteLine("\nMeny:");
                Console.WriteLine("1. Lägg till en bok");
                Console.WriteLine("2. Ta bort en bok");
                Console.WriteLine("3. Sök efter en bok enligt författare");
                Console.WriteLine("4. Visa alla böcker");
                Console.WriteLine("5. Checka ut en bok ");
                Console.WriteLine("6. Returnera en bok");
                Console.WriteLine("7. Avsluta");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        // Lägg till en bok
                        Console.WriteLine("Vad heter boken?");
                        string title = Console.ReadLine();

                        Console.WriteLine("Vad heter författaren?");
                        string author = Console.ReadLine();

                        Console.WriteLine("Vad har den för ISBN?");
                        string isbn = Console.ReadLine();

                        library.CreateBook(title, author, isbn);

                        Console.WriteLine("Boken är nu tillagd!");
                        Thread.Sleep(1000); // Ger lite väntetid för effekt
                        break;

                    case "2":
                        // Ta bort en bok
                        Console.WriteLine("Ange titeln på boken du vill ta bort:");
                        string removeTitle = Console.ReadLine();
                        library.RemoveBook(removeTitle); // Anropar metoden för att ta bort boken
                        break;

                    case "3":
                        // Sök efter en bok enligt författare
                        Console.WriteLine("Ange bokens författare:");
                        string userSearchAuthor = Console.ReadLine();
                        List<Book> foundBook = library.SearchBookByAuthor(userSearchAuthor);
                        if (foundBook != null && foundBook.Count > 0)
                        {
                            foreach (Book book in foundBook)
                            {
                                Console.WriteLine($"Titel: {book.Title}, Författare: {book.Author}, ISBN: {book.ISBN}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ingen bok matchade din sökning.");
                        }
                        break;

                    case "4":
                        // Visa alla böcker
                        library.ShowAllBooks();
                        break;

                    case "5":
                        // Checka ut en bok (not available)
                        Console.WriteLine("Funktionen 'Checka ut en bok' not available.");
                        break;

                    case "6":
                        // Returnera en bok
                        Console.WriteLine("Ange bokens ISBN för att returnera:");
                        string returnIsbn = Console.ReadLine();
                        library.ReturnBook(returnIsbn); // Anropar metoden för att returnera boken
                        break;

                    case "7":
                        // Avsluta programmet
                        running = false;
                        Console.WriteLine("Avslutar programmet...");
                        break;

                    default:
                        Console.WriteLine("Jag förstår inte, försök igen.");
                        break;
                }
            }
        }
    }
}
