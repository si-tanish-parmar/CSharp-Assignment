using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Book
    {
        public string title { get; set; }
        public string author { get; set; }  
        public string genre { get; set; }
        public int quantity { get; set; }

        public Book(string title, string author, string genre, int quantity)
        {
            this.title = title;
            this.author = author;
            this.genre = genre;
            this.quantity = quantity;
        }
        public void Display()
        {
            Console.WriteLine($"Title: {title} Author: {author} Genre: {genre} Quantity: {quantity}");
        }
    }
}
