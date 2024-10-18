using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryGroup
{
    public class Book
    {
        //Variables for the books that will be stored in the List<Books>
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool checkedOut { get; set; }
       

        public Book(string title, string author, string isbn, bool checkedout)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            checkedOut = checkedout;
        }
    }
}
