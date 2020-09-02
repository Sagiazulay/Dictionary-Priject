using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryProject1
{
    public class Book : IComparable<Book>
    {
        public string Title { get; set; }
        public string Content { get; private set; }
        public string Author { get; private set; }
        public string Category { get; private set; }

        public Book(string title, string content, string author, string category)
        {
            this.Author = author;
            this.Category = category;
            this.Content = content;
            this.Title = title;
        }

        public override string ToString()
        {
            return $"Book Author : {Author}, Title : {Title}, Category : {Category}, Content : {Content}";
        }

        public int CompareTo(Book other)
        {
            return Author.CompareTo(other.Author);
        }
    }
}
