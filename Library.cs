using System;
using System.Collections.Generic;

namespace LibraryGroup
{
    public class Library
    {
        // Lista för att lagra alla böcker
        List<Book> bokLista = new List<Book>();

        // Vi skapar en bok och lägger till den i listan
        public void CreateBook(string title, string author, string isbn)
        {
            bokLista.Add(new Book(title, author, isbn, false));
        }

        // Sökmetod för att hitta bok av en specifik författare
        public List<Book> SearchBookByAuthor(string userSearchByAuthor)
        {
            List<Book> foundBook = new List<Book>();
            foreach (Book book in bokLista)
            {
                if (book.Author.Contains(userSearchByAuthor, StringComparison.OrdinalIgnoreCase))
                {
                    foundBook.Add(book);
                }
            }
            return foundBook;
        }

        // Metod för att visa alla böcker i samlingen
        public void ShowAllBooks()
        {
            if (bokLista.Count == 0)
            {
                Console.WriteLine("Det finns inga böcker i samlingen.");
            }
            else
            {
                Console.WriteLine("\nBöcker i samlingen:");
                foreach (Book book in bokLista)
                {
                    Console.WriteLine($"Titel: {book.Title}, Författare: {book.Author}, ISBN: {book.ISBN}, Utlånad: {(book.checkedOut ? "Ja" : "Nej")}");
                }
            }
        }

        // Metod för att lämna tillbaka en bok
        public bool ReturnBook(string isbn)
        {
            foreach (Book book in bokLista)
            {
                if (book.ISBN == isbn && book.returned)
                {
                    book.returned = false;
                    Console.WriteLine($"Boken '{book.Title}' har lämnats tillbaka.");
                    return true;
                }
            }
            Console.WriteLine("Boken finns inte eller är inte utlånad.");
            return false;
        }

        // Metod för att ta bort en bok
        public void RemoveBook(string title)
        {
            bool bookFound = false;
            foreach (var book in bokLista)
            {
                if (book.Title == title)
                {
                    bokLista.Remove(book);
                    Console.WriteLine($"Bok med titeln: {title} har tagits bort!");
                    bookFound = true;
                    break;
                }
            }
            if (!bookFound)
            {
                Console.WriteLine($"Ingen bok med titeln: {title} finns i biblioteket");
            }
        }
    }
}
