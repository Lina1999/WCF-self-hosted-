using Client.ServiceReference2;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new BookServiceClient();
            var book = new Book(1, "Leo Tolstoy", "War and Peace", 25, 1867);
            client.AddBook(book);
            book = new Book(2, "Albert Camus", "The stranger", 20, 1942);
            client.AddBook(book);
            book = new Book(3, "George Orwell", "1984", 23, 1949);
            client.AddBook(book);
            book = new Book(4, "Fyodor Dostoyevsky", "The Brothers Karamazov", 30, 1880);
            client.AddBook(book);
            client.UpdatePrice(3, 25);
            client.GetBookInfo(4);
        }
    }
}
