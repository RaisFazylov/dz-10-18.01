using System;
using System.Collections.Generic;

namespace LibrarySystem
{
    public delegate int BookComparison(Book a, Book b);
    public class BookContainer
    {
        private List<Book> books = new List<Book>();
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void SortBooks(BookComparison comparison)
        {
            books.Sort(new Comparison<Book>(comparison));
        }
    }
}
