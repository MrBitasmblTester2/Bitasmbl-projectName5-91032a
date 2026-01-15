using Microsoft.AspNetCore.Mvc;
using DeveloperReadingListApi.Repositories;
namespace DeveloperReadingListApi.Controllers;
[ApiController]
[Route("api/[controller]")]
public class BooksController : ControllerBase
{
    private readonly IBookRepository _repo;
    public BooksController(IBookRepository repo){_repo = repo;}
}