using System.Collections.Generic;

namespace Alexandria
{
    public class Library
    {
        public Library(string name)
        {
            this.name = name;
            this.shelf = new List<Book>();
        }

        public string name {get; private set;}
        private List<Book> shelf;


        public void AddBook(Book book)
        {
            this.shelf.Add(book);
        }

        public void AddBook(List<Book> books)
        {
            foreach (Book book in books)
            {
                this.shelf.Add(book);  
            }
            
        }

        public Book FindBook(string title)
        {
            var result = this.shelf.Find(x => x.title.Contains(title));
            if (result is null)
            {
                throw new Exception($"'{title}' was not found in the library.");
            }
            return result;
            
        }

    }
}