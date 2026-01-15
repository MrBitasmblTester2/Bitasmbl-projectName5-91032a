using DeveloperReadingListApi.Models;
namespace DeveloperReadingListApi.Repositories;
public interface IBookRepository
{
    IEnumerable<Book> GetAll();
    Book? Get(int id);
    Book Add(Book book);
    bool Update(int id, Book book);
    bool Delete(int id);
}