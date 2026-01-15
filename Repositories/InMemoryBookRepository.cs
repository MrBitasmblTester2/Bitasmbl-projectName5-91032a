using DeveloperReadingListApi.Models;
namespace DeveloperReadingListApi.Repositories;
public class InMemoryBookRepository : IBookRepository
{
    private readonly List<Book> _books = new();
    public IEnumerable<Book> GetAll() => _books;
    public Book? Get(int id) => _books.FirstOrDefault(b => b.Id == id);
    public Book Add(Book book){return book;}
    public bool Update(int id, Book book){return true;}
    public bool Delete(int id){return true;}
}