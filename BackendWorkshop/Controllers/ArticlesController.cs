using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackendWorkshop.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ArticlesController: ControllerBase
{
    private readonly AppDbContext _context;
    private readonly USDbContext _usDbContext;
    private readonly RUDbContext _ruDbContext;

    public ArticlesController(AppDbContext context, USDbContext usDbContext, RUDbContext ruDbContext)
    {
        _context = context;
        _usDbContext = usDbContext;
        _ruDbContext = ruDbContext;
    }
    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Article>>> GetArticles([FromQuery] string region)
    {
        if (region == "us")
        {
            return await _usDbContext.Articles.ToListAsync();
        }
        else if (region == "ru")
        {
            return await _ruDbContext.Articles.ToListAsync();
        }
        else
        {
            return await _context.Articles.ToListAsync();
        }

    }
}