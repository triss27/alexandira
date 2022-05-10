using System;

namespace Alexandria
{
    class Program
    {

        static void Main(string[] args)
        {
            // Create Library
            var alexandria = new Library("Alexandria");

            // Add Books to Library

            var book1 = new Book("Book 1", "Author 1");
            var book2 = new Book("Book 2", "Author 2");
            var book3 = new Book("Book 3", "Author 3");
            var book4 = new Book("Book 4", "Author 4");
            var book5 = new Book("Book 5", "Author 5");
            
            List<Book> books = new List<Book>() {book1, book2, book3, book4, book5};
            alexandria.AddBook(books);

            while (true)
            {
                Console.WriteLine("Enter a title search for (or press Enter to exit):");
                var input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    break;
                }

                try
                {
                    var book = alexandria.FindBook(input);
                    Console.WriteLine($"Title:{book.title}\nAuthor:{book.author}");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }

        }
        
    }
}