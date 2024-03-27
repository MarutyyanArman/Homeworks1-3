using System;
using System.Collections.Generic;

public class Book
{
    private string title;
    private Author author;
    private int year;
    private Category category;
    private double price;

    public Book(string title, Author author, int year, Category category, double price)
    {
        this.title = title;
        this.author = author;
        this.category = category;
        this.year = year;
        this.price = price;
    }

    public string GetTitle()
    {
        return title;
    }

    public Author GetAuthor()
    {
        return author;
    }
    public int GetYear()
    {
        return year;
    }

    public Category GetCategory()
    {
        return category;
    }
    public double GetPrice()
    {
        return price;
    }
}

public class Author
{

    private string name;

    public Author(string name)
    {
        this.name = name;
    }
    public string GetName()
    {
        return name;
    }

}

// Sealed Category class
public sealed class Category
{
    // Properties
    private string categoryName;

    // Constructors
    public Category(string categoryName)
    {
        this.categoryName = categoryName;
    }
    public string GetCategoryName()
    {
        return categoryName;
    }
}

// Static LibraryManager class
public static class LibraryManager
{
    // List to store books
    private static List<Book> books = new List<Book>();

    // Add a new book to the library
    public static void AddBook(Book book)
    {
        books.Add(book);
    }

    // Remove a book from the library by title
    public static void RemoveBook(string title)
    {
        Book removeBook = books.Find(book => book.GetTitle().Equals(title, StringComparison.OrdinalIgnoreCase));
        if (removeBook != null)
        {
            books.Remove(removeBook);
            Console.WriteLine($"Book '{title}' is removed from the library");
        }
        else
        {
            Console.WriteLine($"Book '{title}' not found.");
        }
    }

    // The list of all the books in the library
    public static void ListBooks()
    {
        Console.WriteLine("List of Books in the Library:");
        foreach (var book in books)
        {
            Console.WriteLine($"{book.GetTitle()}({book.GetYear()}), {book.GetAuthor().GetName()}, Category: {book.GetCategory().GetCategoryName()}, Price: {book.GetPrice()}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Authors
        Author author1 = new Author("Name LastName");
        Author author2 = new Author("Name1 LastName1");

        // Categories
        Category category1 = new Category("Comedy");
        Category category2 = new Category("Horror");

        // Books
        Book book1 = new Book("AAA", author1, 1999, category1, 56.11);
        Book book2 = new Book("BBB", author1, 2003, category2, 100.00);
        Book book3 = new Book("CCC", author2, 1986, category1, 32.55);
        Book book4 = new Book("DDD", author2, 2022, category2, 88.77);

        // Add books to the library
        LibraryManager.AddBook(book1);
        LibraryManager.AddBook(book2);
        LibraryManager.AddBook(book3);
        LibraryManager.AddBook(book4);

        // List all the books
        LibraryManager.ListBooks();

        Console.WriteLine("-----------------------");

        // Remove a book
        LibraryManager.RemoveBook("AAA");
        LibraryManager.RemoveBook("CCC");
        LibraryManager.RemoveBook("EEE");

        Console.WriteLine("-----------------------");

        // The new list 
        LibraryManager.ListBooks();

        Console.ReadLine();
    }
}