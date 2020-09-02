using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DictionaryProject1
{
    class MyLibrary
    {
        private Dictionary<string, Book> books = new Dictionary<string, Book>();

        public Dictionary<string, Book> Books
        {
            get => books;
            set => books = value;
        }

        public MyLibrary()
        {
                
        }

        public bool AddBook(Book b)
        {
            if (books.ContainsKey(b.Title))
                return false;
            books.Add(b.Title, b);
            return true;
        }

        public bool HaveThisBook(string title)
        {
            return books.ContainsKey(title);

        }
        public bool RemoveBook(string title)
        {
            if (books.ContainsKey(title))
            {
                books.Remove(title);
                return true;
            }

            return false;
        }

        public Book GetBook(string title)
        {
           return books.TryGetValue(title, out Book book) ? book : null;
        }

        public Book GetBookByAuthor(string author)
        {
            foreach (Book book in books.Values)
            {
                if (book.Author == author)
                    return book;
            }
            return null;
        }

        public void clear()
        {
            books.Clear();
        }

        public List<string> GetAuthors()
        {
            List<string> allAuthors = new List<string>();

            foreach (Book book in books.Values)
            {
                allAuthors.Add(book.Author);
            }

            return allAuthors;
        }

        public List<Book> GetBooksSortedByAuthorsName()
        {
             return books.Values.OrderBy(b => b.Author).ToList();//(From Mark)
        }

        public List<string> GetBooksTitleSorted()
        {
            return books.Keys.OrderBy(b => b).ToList();//(From Sagi)
        }

        public override string ToString()
        {
            string allBooks = "";
            foreach (Book book in books.Values)
            {
                allBooks += book + " /n";

            }
            return allBooks;
        }
    }
}
