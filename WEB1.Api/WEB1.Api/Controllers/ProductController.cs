using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEB1.Api.Interfaces.Infrastructure;
using WEB1.Core.Entities;
using WEB1.Core.Interfaces.Service;
using WEB1.Core.Service;
using WEB1.Infrastructure.Repository;

namespace WEB1.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProductService _productService;
        IProductRepository _productRepository;
        public ProductController(IProductService productService, IProductRepository productRepository)
        {
            _productService = productService;
            _productRepository = productRepository;
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var products = _productRepository.GetProducts();
                return Ok(products);
            }
            catch (Exception ex)
            {
                var result = new
                {
                    devMsg = ex.Message,
                    userMag = "Có lỗi xảy ra",
                    data = ""
                };    
                return StatusCode(500, result);
            }
        }

        [HttpPost]
        public IActionResult Insert(Product product)
        {
            try
            {
                var res = _productService.InsertService(product);
                if(res > 0)
                    return StatusCode(201, res);
                else
                    return Ok(res);
            }
            catch (Exception ex)
            {
                var result = new
                {
                    devMsg = ex.Message,
                    userMag = "Có lỗi xảy ra",
                    data = ""
                };
                return StatusCode(500, result);
            }
        }
    }
}
