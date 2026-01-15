namespace DeveloperReadingListApi.DTOs;
public class BookCreateDto
{
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public List<int> TagIds { get; set; } = new();
}
public class BookReadDto
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
}