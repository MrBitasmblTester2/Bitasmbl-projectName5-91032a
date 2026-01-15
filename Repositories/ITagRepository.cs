using DeveloperReadingListApi.Models;
namespace DeveloperReadingListApi.Repositories;
public interface ITagRepository
{
    IEnumerable<Tag> GetAll();
    Tag? Get(int id);
    Tag Add(Tag tag);
    bool Update(int id, Tag tag);
    bool Delete(int id);
}