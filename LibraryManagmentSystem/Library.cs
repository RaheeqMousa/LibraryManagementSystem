using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem
{
    class Library
    {
        List<Book> books;
        List<Person> Members;
        public Library() {
            books = new List<Book>();
            Members=new List<Person>();
        }
        public Library(List<Book> books, List<Person> members)
        {
            this.books = books;
            this.Members = members;
        }

        public bool addBook(Book b) {
            if (books.Contains(b))
            {
                return false;
            }
            else {
                books.Add(b);
                return true;
            }
        }

        public bool addMember(Person member)
        {
            if (Members.Contains(member))
            {
                return false;
            }
            else
            {
                Members.Add(member);
                return true;
            }
        }

        public Person FindMemberById(int id) {
            foreach (Person member in Members) {
                if (member.Id == id) { 
                    return member;
                }
            }

            return null;
        
        }

        public Book FindBookById(int id)
        {
            foreach (Book book in books)
            {
                if (book.Id == id)
                {
                    return book;
                }
            }

            return null;

        }

        public void DisplayAllBooks() {
            Console.WriteLine($"{string.Join("\n",books)}");
        }

        public void DisplayAllMembers() {
            Console.WriteLine($"{string.Join("\n", Members)}");
        }


    }
}
