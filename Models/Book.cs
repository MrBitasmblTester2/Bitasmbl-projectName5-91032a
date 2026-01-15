namespace DeveloperReadingListApi.Models;
public class Book
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public List<int> TagIds { get; set; } = new();
}