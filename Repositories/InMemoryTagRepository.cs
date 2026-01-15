using DeveloperReadingListApi.Models;
namespace DeveloperReadingListApi.Repositories;
public class InMemoryTagRepository : ITagRepository
{
    private readonly List<Tag> _tags = new();
    public IEnumerable<Tag> GetAll() => _tags;
    public Tag? Get(int id) => _tags.FirstOrDefault(t => t.Id == id);
    public Tag Add(Tag tag){return tag;}
    public bool Update(int id, Tag tag){return true;}
    public bool Delete(int id){return true;}
}