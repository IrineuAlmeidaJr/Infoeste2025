using Application.DTO.Product;
using Application.DTOs.Product;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Incoming.Http;

[ApiController]
[Route("/api/v1/[controller]")]
public class ProductsController(IProductService service) : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult<ProductResponseDto>> Create([FromBody] ProductCreateDto request)
    {
        var response = await service.Create(request);
        return new CreatedAtRouteResult("GetProduct", new { id = response.Id },
            response);
    }

    [HttpPut]
    public async Task<ActionResult<ProductResponseDto>> Put(long id, [FromBody] ProductUpdateDto request)
    {
        var response = await service.Update(id, request);
        return Ok(response);
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult> Delete(int id)
    {
        await service.Remove(id);
        return NoContent();
    }

    [HttpGet("{id:int}", Name = "GetProduct")]
    public async Task<ActionResult<ProductResponseDto>> GetProduct(int id)
    {
        var response = await service.GetById(id);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProductResponseDto>>> Get(
        [FromQuery] int page = 1,
        [FromQuery] int pageSize = 20,
        [FromQuery] string name = "")
    {
        var response = await service.GetProductsPaged(name, page, pageSize);
        return Ok(response);
    }
}
