using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Library
    {
        private Book[] books;
        private int bookCount;

        public Library() {
            books = new Book[10];
            bookCount = 0;
        }
        public void AddBook(Book book) {
            if (bookCount < books.Length) { books[bookCount] = book; bookCount++;
            }
            else
            {
                Console.WriteLine("The list is full.");
            }
        }
        public void RemoveBook() { 
        }
        public void Update()
        {

        }
        
       

    }
}
