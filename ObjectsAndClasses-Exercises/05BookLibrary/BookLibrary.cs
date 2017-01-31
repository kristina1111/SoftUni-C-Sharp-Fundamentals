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
            while (numberOfBooks > 0)
            {
                string[] inputArray = Console.ReadLine().Split(' ').ToArray();
                Book newBook = ReturnBook(inputArray);
                libraryOne.ListOfBooks.Add(newBook);
                numberOfBooks--;
            }

            Dictionary<string, double> byAuthor = new Dictionary<string, double>();
            for(int i =0;i<libraryOne.ListOfBooks.Count; i++)
            {
                string author = libraryOne.ListOfBooks[i].Author;
                if (!byAuthor.ContainsKey(author))
                {
                    byAuthor.Add(author, libraryOne.ListOfBooks[i].Price);
                }
                else
                {
                    byAuthor[author] += libraryOne.ListOfBooks[i].Price;
                }
            }
            
            foreach (KeyValuePair<string, double> author in byAuthor.OrderByDescending(i => i.Value).ThenBy(i => i.Key))
            {
                Console.WriteLine("{0} -> {1:f2}", author.Key, author.Value);
            }

        }
        static Book ReturnBook(string[] infoArray)
        {
            Book bookObject = new Book()
            {
                Title = infoArray[0],
                Author = infoArray[1],
                Publisher = infoArray[2],
                DatePublished = DateTime.ParseExact(infoArray[3],"dd.MM.yyyy", null),
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
