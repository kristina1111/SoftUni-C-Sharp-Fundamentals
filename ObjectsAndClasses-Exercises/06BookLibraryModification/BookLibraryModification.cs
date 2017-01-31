using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05BookLibrary
{
    class BookLibrary
    {
        static void Main(string[] args)
        {
            int numberOfBooks = int.Parse(Console.ReadLine());
            Library libraryOne = new Library();
            int cnt = 0;
            while (numberOfBooks > 0)
            {
                string[] inputArray = Console.ReadLine().Split(' ').ToArray();
                Book newBook = ReturnBook(inputArray);
                libraryOne.ListOfBooks.Add(newBook);
                numberOfBooks--;
                cnt++;
            }
            DateTime dateToCompare = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);
            
            foreach (Book x in libraryOne.ListOfBooks.OrderBy(x=>x.DatePublished).ThenBy(x=>x.Title).Where(x=>x.DatePublished>dateToCompare))
            {
                Console.WriteLine("{0} -> {1:dd.MM.yyyy}", x.Title, x.DatePublished);
            }

        }
        static Book ReturnBook(string[] infoArray)
        {
            Book bookObject = new Book()
            {
                Title = infoArray[0],
                Author = infoArray[1],
                Publisher = infoArray[2],
                DatePublished = DateTime.ParseExact(infoArray[3], "dd.MM.yyyy", null),
                ISBN = infoArray[4],
                Price = double.Parse(infoArray[5]),
            };
            return bookObject;
        }
    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime DatePublished { get; set; }
        public string ISBN { get; set; }
        public double Price { get; set; }
    }
    class Library
    {
        public string Name { get; set; }
        public List<Book> ListOfBooks { get; set; }
        public Library()
        {
            ListOfBooks = new List<Book>();
        }
    }
}
