using System.Numerics;

namespace LibraryManagmentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            if (library.addBook(new Book(1, "1984", "George Orwell")))
                Console.WriteLine("Book added successfully");
            if (library.addBook(new Book(2, "1984", "George Orwell")))
                Console.WriteLine("Book added successfully");
            if (library.addBook(new Book(3, "1984", "George Orwell")))
                Console.WriteLine("Book added successfully");


            if (library.addMember(new Member(1, "Ali")))
                Console.WriteLine("Member added successfully");
            if (library.addMember(new Member(2, "Raheeq")))
                Console.WriteLine("Member Added successfully");

            while (true) {
                displayOptions();
                Console.Write("Choose option");
                string choice= (Console.ReadLine()).Trim();

                switch (choice) {

                    case "1":
                        library.DisplayAllBooks();
                        break;
                    case "2":
                        library.DisplayAllMembers();
                        break;
                    case "3":
                        Console.Write("Enter Member ID");
                        int mID=int.Parse(Console.ReadLine());
                        Console.Write("Enter Book ID");
                        int bID = int.Parse(Console.ReadLine());

                        Person s=library.FindMemberById(mID);
                        Book b=library.FindBookById(bID);

                        if (s!=null && s is Member m && b != null)
                        {
                            if (m.BorrowBook(b))
                            {
                                Console.WriteLine("Book has been borrowed successfully.");
                                b.IsAvailable = false;
                            }
                            else if (m.BorrowedBooks.Contains(b))
                                Console.WriteLine("This Member already Borrowed this Book.");
                            else
                                Console.WriteLine("This Book is borrowed by someone else");
                        }
                        else { 
                            Console.WriteLine("Invalid Member or Book ID");
                        }
                        break;
                    case "4":
                        Console.Write("Enter Member ID");
                        int mID2 = int.Parse(Console.ReadLine());
                        Console.Write("Enter Book ID");
                        int bID2 = int.Parse(Console.ReadLine());

                        Person s2 = library.FindMemberById(mID2);
                        Book b2 = library.FindBookById(bID2);

                        if (s2!=null && s2 is Member m2 && b2 != null)
                        {
                            if (m2.ReturnBook(b2))
                            {
                                b2.IsAvailable = true;
                                Console.WriteLine("Book has been Returned successfully.");
                            }
                            else
                                Console.WriteLine("This Member Has not Borrowed this Book!");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Member or Book ID");
                        }
                        break;
                    case "5":
                        Console.Write("Enter Member ID");
                        int id = int.Parse(Console.ReadLine());
                        Person p= library.FindMemberById(id);
                        if (p!=null && p is Member m3)
                        {
                            m3.DisplayBorrowedBooks();    
                        }
                        else {
                            Console.WriteLine("Invalid Member ID.");
                        }
                    break;
                    case "0":
                        Console.WriteLine("Good Bye");
                        return;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }

        }

        public static void displayOptions() {


            string options = "\n---LibraryMenu---" +
                "\n1. Show all Books" +
                "\n2. Show all Members" +
                "\n3. Borrow Book" +
                "\n4. Return Book" +
                "\n5. Show member borrowed books" +
                "\n0. Exit";

            Console.WriteLine(options);
        }

    }
}
