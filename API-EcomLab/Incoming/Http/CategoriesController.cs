using Application.DTOs.Category;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Incoming.Http;

[ApiController]
[Route("/api/v1/[controller]")]
public class CategoriesController(ICategoryService service) : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult<CategoryDto>> Create([FromBody] CategoryDto request)
    {
        var response = await service.Create(request);
        return new CreatedAtRouteResult("GetCategory", new { id = response.Id },
            response);
    }

    [HttpPut]
    public async Task<ActionResult<CategoryDto>> Put(long id, [FromBody] CategoryDto request)
    {
        var response = await service.Update(id, request);
        return Ok(response);
    }

    [HttpDelete("{id:long}")]
    public async Task<ActionResult> Delete(long id)
    {
        await service.Remove(id);
        return NoContent();
    }

    [HttpGet("{id:long}", Name = "GetCategory")]
    public async Task<ActionResult<CategoryDto>> GetCategory(long id)
    {
        var response = await service.GetById(id);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<CategoryDto>>> Get(
        [FromQuery] int page = 1,
        [FromQuery] int pageSize = 20,
        [FromQuery] string name = "")
    {
        return Ok(await service.GetCategoriesPaged(name, page, pageSize));
    }
}
