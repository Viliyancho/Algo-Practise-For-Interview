using System.Reflection.Metadata.Ecma335;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string AuthorName { get; set; }
}

public interface IBookRepository
{
    List<Book> GetAll();
    Book? GetBook(int id);
    void Add(Book book);
    void Update(Book book);
    void Delete(int id);
}

public class InMemoryBookRepository : IBookRepository
{
    List<Book> books = new List<Book>();
    int nextIndex = 1;
    public List<Book> GetAll() => books;
    public Book? GetBook(int id) => books.FirstOrDefault(b => b.Id == id);
    public void Add(Book book)
    {
        book.Id = nextIndex++;
        books.Add(book);
    }

    public void Delete(int id)
    {
        var existing = books.FirstOrDefault(b => b.Id == id);
        if (existing == null)
            return;

        books.RemoveAll(b => b.Id == id);
    }



    public void Update(Book book)
    {
        var existing = books.FirstOrDefault(b => b.Id == book.Id);

        existing.AuthorName = book.AuthorName;
        existing.Title = book.Title;
    }
}