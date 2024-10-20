namespace LibraryGroup
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Vi Välkommnar och skapar biblioteket
            Console.WriteLine("Välkommen!");
            Library library = new Library();

            //Vi skapar en program loop
            bool running = true;
            while (running) {

                printList();
                string input = Console.ReadLine();

                switch (input) {

                    case "1":
                        //Vi skapar en bok
                        Console.WriteLine("Vad heter boken?");
                        string title = Console.ReadLine();

                        Console.WriteLine("Vad heter författaren?");
                        string author = Console.ReadLine();

                        Console.WriteLine("Vad har den för ISBN?");
                        string isbn = Console.ReadLine();

                        library.CreateBook(title, author, isbn);

                        //Ge lite väntetid för effekt
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;

                    case "2":
                        //Vi tar bort en bok
                        Console.WriteLine("Ange titel på den bok du vill ta bort från biblioteket: ");
                        string bookToRemove = Console.ReadLine();
                        library.RemoveBook(bookToRemove);
                        Thread.Sleep(1000);//Ge lite väntetid för effekt
                        Console.Clear();
                        break;

                    case "3":
                        Console.WriteLine("Ange bokens författare");
                        string userSearchAuthor = Console.ReadLine();
                        library.SearchBook(userSearchAuthor);
                        Thread.Sleep(1000);
                        break;

                    case "4":
                        // Anropar metoden för att visa alla böcker
                        library.ShowAllBooks();
                        Thread.Sleep(1000);
                        break;

                    case "5":
                        Console.WriteLine("Vad har boken är IBSN");
                        library.checkoutReturn(Console.ReadLine(), true);
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;

                    case "6":
                        Console.WriteLine("Vad har boken är IBSN");
                        library.checkoutReturn(Console.ReadLine(), false);
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;

                    case "7":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Jag förstår inte");
                        break;
            
                }

            }
        }

        //Listan som visas i början av programmet
        static void printList()
        {
            Console.WriteLine("1. Lägg till en bok");
            Console.WriteLine("2. Ta bort en bok");
            Console.WriteLine("3. Sök efter en bok enligt författare");
            Console.WriteLine("4. Visa alla böcker");
            Console.WriteLine("5. Checka ut bok");
            Console.WriteLine("6. Returnera bok");
            Console.WriteLine("7. Avsluta");
        }
    }
}