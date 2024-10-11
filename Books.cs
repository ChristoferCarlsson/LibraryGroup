using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryGroup
{
    
    internal class Books
    {
        List<Books> bokLista = new List<Books>(); 

        //Variables for the books that will be stored in the List<Books>
        public string Title;
        public string Author;
        public string ISBN;
        public bool checkedOut;

    }
}