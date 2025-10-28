using Application.DTO.Products;
using Application.DTOs;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Incoming.Http;

[ApiController]
[Route("/api/v1/[controller]")]
public class ProductsController(IProductService service) : ControllerBase
{
    [HttpGet("{id:Guid}", Name = "GetProduct")]
    public async Task<ActionResult<ProductResponseDto>> GetProduct([FromRoute] Guid id)
    {
        var response = await service.GetById(id);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<PagedResultDto<ProductResponseDto>>> Get(
        [FromQuery] int page = 1,
        [FromQuery] int pageSize = 20,
        [FromQuery] string name = "",
        [FromQuery] string orderBy = "",
        [FromQuery] string sortDirection = "asc",
        [FromQuery] bool isOnSale = false,
        [FromQuery] double priceMin = 0,
        [FromQuery] double priceMax = 0)
    {
        var response = await service.GetProductsPaged(page, pageSize, name, orderBy, sortDirection,
            isOnSale, priceMin, priceMax);
        return Ok(response);
    }
}
