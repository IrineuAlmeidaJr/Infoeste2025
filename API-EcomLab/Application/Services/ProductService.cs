using Application.DTO.Product;
using Application.DTOs;
using Application.DTOs.Product;
using Application.UseCases.Brands;
using Application.UseCases.Products;

namespace Application.Services;

public class ProductService(
    ICreateProduct createProduct,
    IUpdateProduct updateProduct,
    ISetProductStatus setProductStatus,
    IGetProductResponseDtoById getProductResponseDtoById,
    IGetProductsPaged getProductsPaged) : IProductService
{
    public async Task<ProductResponseDto> Create(ProductCreateDto productCreateDto)
    {
        return await createProduct.Execute(productCreateDto);
    }

    public async Task<ProductResponseDto> Update(long id, ProductUpdateDto productUpdateDto)
    {
        return await updateProduct.Execute(id, productUpdateDto);
    }

    public async Task SetProductStatus(long id, bool isActive)
    {
        await setProductStatus.Execute(id);
    }

    public async Task<ProductResponseDto> GetById(long id)
    {
        return await getProductResponseDtoById.Execute(id);
    }

    public async Task<PagedResultDto<ProductResponseDto>> GetProductsPaged(string name, int page, int pageSize)
    {
        return await getProductsPaged.Execute(name, page, pageSize);
    }
}
