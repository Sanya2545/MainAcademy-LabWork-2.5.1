using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSharp_Net_module3_1_1_lab.Models
{
    public class Books
    {
        // 2) Declare list of BookModels
        private List<BookModels> books;

        public Books()
        {
            books = new List<BookModels>();
            books.Add(new Models.BookModels(1, "Harry Potter", "Some story to tell", "J.K. Rowling"));
            books.Add(new Models.BookModels(2, "Harry Potter", "Some story to tell", "J.K. Rowling"));
            books.Add(new Models.BookModels(3, "Harry Potter", "Some story to tell", "J.K. Rowling"));
            books.Add(new Models.BookModels(4, "Harry Potter", "Some story to tell", "J.K. Rowling"));
            // 3) Add several books to list

        }

        // 4) Change parameters and return type of CreateBook()
        public void CreateBook(int id, string name, string title, string author)
        {
            books.Add(new Models.BookModels(id, name, title, author));
        }

        // 6) Change parameters and return type of UpdateBook()
        public bool UpdateBook(BookModels bookModel)
        {
            foreach (var item in books)
            {
                if (item.ID == bookModel.ID)
                {
                    books.Remove(item);
                    books.Add(item);
                    return true;
                }
            }
            return false;
            // 7) use foreach to move through all books in list;
            // if book is find: remove it and add new from parameter
        }

    }
}