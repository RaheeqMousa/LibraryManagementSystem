using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem
{
    class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorName {  get; set; }
        public bool IsAvailable { get; set; }

        public Book() { }
        public Book(int id) { }

        public Book(int id, string title)
        {
            Id = id;
            Title = title;
            AuthorName = "not known";
            IsAvailable = true;
        }
        public Book(int id, string title, string authorName)
        {
            Id = id;
            Title = title;
            AuthorName = authorName;
            IsAvailable = true;
        }
        public Book(int id, string title, string authorName, bool isAvailable)
        {
            Id = id;
            Title = title;
            AuthorName = authorName;
            IsAvailable = isAvailable;
        }

        public void DisplayInfo()
        {
            Console.WriteLine ($"ID: {this.Id}, Title: {this.Title}, AuthorName: {this.AuthorName}, IsAvailable: {this.IsAvailable}");
        }

        public override string ToString()
        {
            return ($"ID: {this.Id}, Title: {this.Title}, AuthorName: {this.AuthorName}, IsAvailable: {this.IsAvailable}");
        }


    }
}
