using Application.DTOs.Brand;
using Application.DTOs.Category;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Incoming.Http;

[ApiController]
[Route("/api/v1/[controller]")]
public class BrandsController(IBrandService service) : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult<BrandDto>> Create([FromBody] BrandDto request)
    {
        var response = await service.Create(request);
        return new CreatedAtRouteResult("GetBrand", new { id = response.Id },
            response);
    }

    [HttpPut]
    public async Task<ActionResult<BrandDto>> Put(long id, [FromBody] BrandDto request)
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


    [HttpGet("{id:long}", Name = "GetBrand")]
    public async Task<ActionResult<BrandDto>> GetBrand(long id)
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
        return Ok(await service.GetBrandsPaged(name, page, pageSize));
    }
}
