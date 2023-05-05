using System;
using System.Collections.Generic;

class Book {
    public string title;
    public string author;
    public int year;
}

class Library {
    private List<Book> books;

    public Library() {
        books = new List<Book>();
    }

    public void AddBook(Book book) {
        books.Add(book);
    }

    public void RemoveBook(string title) {
        books.RemoveAll(book => book.title == title);
    }

    public void ListBooks() {
        Console.WriteLine("{0,-30} {1,-20} {2,-5}", "Title", "Author", "Year");
        Console.WriteLine("{0,-30} {1,-20} {2,-5}", "-----", "------", "----");
        foreach (Book book in books) {
            Console.WriteLine("{0,-30} {1,-20} {2,-5}", book.title, book.author, book.year);
        }
    }

    public List<Book> FindByAuthor(string author) {
        return books.FindAll(book => book.author == author);
    }

    public List<Book> FindByTitle(string title) {
        return books.FindAll(book => book.title == title);
    }

    public void SortByTitle() {
        books.Sort((book1, book2) => book1.title.CompareTo(book2.title));
    }

    public void SortByAuthor() {
        books.Sort((book1, book2) => book1.author.CompareTo(book2.author));
    }

    public void SortByYear() {
        books.Sort((book1, book2) => book1.year.CompareTo(book2.year));
    }

    public int CountBooks() {
        return books.Count;
    }
}

class Program {
    static void Main(string[] args) {
        Library library = new Library();

            Console.WriteLine();
            Console.WriteLine();
        while (true) {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Add book");
            Console.WriteLine("2. Remove book");
            Console.WriteLine("3. List books");
            Console.WriteLine("4. Find by author");
            Console.WriteLine("5. Find by title");
            Console.WriteLine("6. Sort by title");
            Console.WriteLine("7. Sort by author");
            Console.WriteLine("8. Sort by year");
            Console.WriteLine("9. Count books");
            Console.WriteLine("0. Exit");

            Console.WriteLine();
            Console.WriteLine();
            string input = Console.ReadLine();

Max, [31.03.2023 15:02]
switch (input) {
                case "1":
                    Console.Write("Title: ");
                    string title = Console.ReadLine();
                    Console.Write("Author: ");
                    string author = Console.ReadLine();
                    Console.Write("Year: ");
                    int year = int.Parse(Console.ReadLine());
                    library.AddBook(new Book { title = title, author = author, year = year });
                    Console.WriteLine("Book added.");
                    Console.WriteLine();
                    break;
                case "2":
                    Console.Write("Title: ");
                    string removeTitle = Console.ReadLine();
                    library.RemoveBook(removeTitle);
                    Console.WriteLine("Book removed.");
                    Console.WriteLine();
                    break;
                case "3":
                    library.ListBooks();
                    Console.WriteLine();
                    break;
                case "4":
                    Console.WriteLine();
                    Console.Write("Author: ");
                    string findAuthor = Console.ReadLine();
                    List<Book> foundByAuthor = library.FindByAuthor(findAuthor);
                    Console.WriteLine("{0,-30} {1,-20} {2,-5}", "Title", "Author", "Year");
                    Console.WriteLine("{0,-30} {1,-20} {2,-5}", "-----", "------", "----");
                    foreach (Book book in foundByAuthor) {
                        Console.WriteLine("{0,-30} {1,-20} {2,-5}", book.title, book.author, book.year);
                    }
                    Console.WriteLine();
                    break;
                case "5":
                    Console.WriteLine();
                    Console.Write("Title: ");
                    string findTitle = Console.ReadLine();
                    List<Book> foundByTitle = library.FindByTitle(findTitle);
                    Console.WriteLine("{0,-30} {1,-20} {2,-5}", "Title", "Author", "Year");
                    Console.WriteLine("{0,-30} {1,-20} {2,-5}", "-----", "------", "----");
                    foreach (Book book in foundByTitle) {
                        Console.WriteLine("{0,-30} {1,-20} {2,-5}", book.title, book.author, book.year);
                    }
                    Console.WriteLine();
                    break;
                case "6":
                    library.SortByTitle();
                    Console.WriteLine("Sorted by title.");
                    Console.WriteLine();
                    library.ListBooks();
                    break;
                case "7":
                    library.SortByAuthor();
                    Console.WriteLine("Sorted by author.");
                    Console.WriteLine();
                    library.ListBooks();
                    break;
                case "8":
                    library.SortByYear();
                    Console.WriteLine("Sorted by year.");
                    Console.WriteLine();
                    library.ListBooks();
                    break;
                case "9":
                    Console.WriteLine("There are {0} books in the library.", library.CountBooks());
                    Console.WriteLine();
                    break;
                case "0":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
            }
            Console.WriteLine();
        }
    }
