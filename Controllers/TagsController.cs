using Microsoft.AspNetCore.Mvc;
using DeveloperReadingListApi.Repositories;
namespace DeveloperReadingListApi.Controllers;
[ApiController]
[Route("api/[controller]")]
public class TagsController : ControllerBase
{
    private readonly ITagRepository _repo;
    public TagsController(ITagRepository repo){_repo = repo;}
}