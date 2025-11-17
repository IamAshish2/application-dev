using System.Reflection;

namespace task05;

public class Program
{
    public static void Main(string[] args)
    {
        // take the input from the user
        Console.Write("Please enter the day (e.g., Sunday): ");
        string inputDay = Console.ReadLine()?.Trim();

        // Convert to lowercase to make the comparison case-insensitive
        string day = inputDay.ToLower();
        DayType type;
        if (day == "friday" || day == "saturday")
        {
            type = DayType.Weekend;
        }
        else
        {
            type = DayType.Weekday;
        }

        Console.WriteLine($"It is: {type}");


        // record 
        Book book = new Book("The Lord of the Rings", "Ashish Karki", 444.49);

        Book newBook = book with
        {
            title = "My new book2"
        };

        Console.WriteLine(
            $"The name of the book is {book.title}. The author is {book.author}. It costs {newBook.price}.");

        (string title, string author, double price) = newBook;
        Console.WriteLine("Deconstructed values");
        Console.WriteLine(
            $"The title of the book is {title}. The author is {author} and the price is {newBook.price}.");
    }
}