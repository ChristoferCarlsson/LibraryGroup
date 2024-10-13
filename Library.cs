﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibraryGroup
{
    public class Library
    {
        List<Book> bokLista = new List<Book>();

        //Vi skapar en bok och lägger till den i listan
        public void CreateBook(string title, string author, string isbn)
        {
            bokLista.Add(new Book(title, author, isbn, false));

        }
        // Sökmetod för att hitta bok av en specifik titel
        public List<Book> SearchBookByAuthor(string userSearchByAuthor)
        {
            List<Book > foundBook = new List<Book>();
            string bookByAuthor = userSearchByAuthor;
            foreach (Book book in bokLista)
            {
                if (book.Author.Contains(bookByAuthor))
                {
                    foundBook.Add(book);
                }
            }
            return foundBook;
        }
    }
}