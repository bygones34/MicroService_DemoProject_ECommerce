using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Catalog.DTOs.ProductImageDTOs;
using MultiShop.Catalog.Services.ProductImageServices;

namespace MultiShop.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductImagesController : ControllerBase
    {
        private readonly IProductImageService _productImageService;
        public ProductImagesController(IProductImageService productImageService)
        {
            _productImageService = productImageService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProductImagesAsync()
        {
            var values = await _productImageService.GetAllProductImagesAsync();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductImageByIdAsync(string id)
        {
            var values = await _productImageService.GetByIdProductImageAsync(id);
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProductImageAsync(CreateProductImageDto createProductImageDto)
        {
            await _productImageService.CreateProductImageAsync(createProductImageDto);
            return Ok("Product images were created successfully!");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProductImageAsync(string id)
        {
            await _productImageService.DeleteProductImageAsync(id);
            return Ok("Product images were deleted successfully!");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProductImageAsync(UpdateProductImageDto updateProductImageDto)
        {
            await _productImageService.UpdateProductImageAsync(updateProductImageDto);
            return Ok("Product images were updated successfully!");
        }
    }
}
