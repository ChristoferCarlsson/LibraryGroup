using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibraryGroup
{
    public class Library
    {
        //Vi skapar en bok lista
        List<Book> bokLista = new List<Book>();

        //Vi skapar en bok och lägger till den i listan
        public void CreateBook(string title, string author, string isbn)
        {
            //Om title, author, eller isbn är tomma, så skapas inte boken
            if (title == "" || author == "" || isbn == "")
            {
                Console.WriteLine("Var vänlig och fyll i alla fält!");
                return;
            }

            //Vi kollar om ISBN redan finns registerad 
            bool exist = false;
            foreach (Book book in bokLista)
            {
                if (book.ISBN == isbn)
                {
                    Console.WriteLine("Den här ISBN finns redan");
                    exist = true;
                    break;
                }
            }

            //Om ISBN inte finns så skapas boken
            if (!exist)
            {
                bokLista.Add(new Book(title, author, isbn, false));
                Console.WriteLine("Boken är nu tillagd!");
            }

        }

        // Sökmetod för att hitta bok av en specifik författare
        public List<Book> SearchBookByAuthor(string userSearchByAuthor)
        {
            List<Book> foundBooks = new List<Book>();
            foreach (Book book in bokLista)
            {
                if (book.Author == userSearchByAuthor)
                {
                    foundBooks.Add(book);
                }
            }
            return foundBooks;
        }


        //Vi söker efter en bok via författaren
        public void SearchBook(string author)
        {
            List<Book> foundBooks = new List<Book>();
            foreach (Book book in bokLista)
            {
                if (book.Author == author)
                {
                    foundBooks.Add(book);
                }
            }

            //Om boklistan inte är tom
            if (foundBooks != null && foundBooks.Count > 0)
            {
                //Om det finns mer än en bok så ändras texten
                string result = (foundBooks.Count > 1) ? "Följande böcker matchade din sökning" : "Följande bok matchade din sökning";
                Console.WriteLine(result);

                foreach (Book book in foundBooks)
                {
                    Console.WriteLine($"Titel: {book.Title}, Författare: {book.Author}, ISBN: {book.ISBN}, Utlånad: {(book.checkedOut ? "Ja" : "Nej")}");
                }
            }
            else
            {
                Console.WriteLine("Ingen bok matchade din sökning");
            }
        }

        //Metod för att ta bort bok från listan. 
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

        //We combined two functions into a singular one.
        public void checkoutReturn(string isbn, bool checkOut)
        {
            foreach (Book book in bokLista)
            {
                //Om boken finns och inte är utcheckad
                if (book.ISBN == isbn && !book.checkedOut)
                {
                    //Om vi vill checka ut
                    if (checkOut)
                    {
                        book.checkedOut = true;
                        Console.WriteLine($"Du har checkat ut boken \"{book.Title}\"");
                        break;
                    }
                    //Om vi vill retunera bok
                    else
                    {
                        Console.WriteLine("Boken är inte utlånad");
                    }
                }
                //Om boken finns och är utcheckad
                else if (book.ISBN == isbn && book.checkedOut)
                {
                    if (checkOut)
                    {
                        Console.WriteLine($"Boken \"{book.Title}\" är redan utlånad.");
                        break;
                    }
                    else
                    {
                        book.checkedOut = false;
                        Console.WriteLine($"Du har lämnat tillbaka boken \"{book.Title}\"");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine($"Boken finns inte.");
                    break;
                }
            }
        }

    }

}
