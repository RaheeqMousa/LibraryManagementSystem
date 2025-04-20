using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem
{
    class Member : Person
    {
        public List<Book> BorrowedBooks {  get; set; }

        public Member() {
            BorrowedBooks = new List<Book>();
        }

        public Member(int id, string name) : base(id,name)
        {
            BorrowedBooks = new List<Book>();
        }

        public Member(List<Book> borrowedBooks, int id, string name) : this(id,name)
        {
            BorrowedBooks = borrowedBooks;
        }


        public bool BorrowBook(Book book) {
            if (BorrowedBooks.Contains(book))
            {
                return false;
            }
            else {
                if (book.IsAvailable) { 
                    BorrowedBooks.Add(book);
                    return true;
                }else {
                    return false;
                }
            }
        }

        public bool ReturnBook(Book book) {
            if (!BorrowedBooks.Contains(book))
            {
                return false;
            }
            else { 
                BorrowedBooks.Remove(book);
                return true;
            }
        }

        public void DisplayBorrowedBooks() {
            Console.WriteLine($"{string.Join("\n",BorrowedBooks)}");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {this.Name}, ID:{this.Id}, {string.Join("\n", BorrowedBooks)}");
        }
        public override string ToString()
        {
            return ($"{base.ToString()}, {string.Join("\n", BorrowedBooks)}");
        }

    }
}
