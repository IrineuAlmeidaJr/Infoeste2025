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
    public async Task<ActionResult<ProductResponseDto>> Put([FromQuery] long id, [FromBody] ProductUpdateDto request)
    {
        var response = await service.Update(id, request);
        return Ok(response);
    }

    [HttpPatch("{id:long}")]
    public async Task<ActionResult> SetProductStatus([FromRoute] long id, [FromQuery] bool isActive)
    {
        await service.SetProductStatus(id, isActive);
        return NoContent();
    }

    [HttpGet("{id:long}", Name = "GetProduct")]
    public async Task<ActionResult<ProductResponseDto>> GetProduct([FromRoute] long id)
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
