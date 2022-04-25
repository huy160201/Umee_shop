using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEB1.Api.Interfaces.Infrastructure;
using WEB1.Core.Entities;
using WEB1.Core.Exceptions;
using WEB1.Core.Interfaces.Service;
using WEB1.Core.Service;
using WEB1.Infrastructure.Repository;

namespace WEB1.Api.Controllers
{
    public class ProductController : BaseController<Product>
    {
        public ProductController(IProductService productService, IProductRepository productRepository):base(productService, productRepository) 
        {
        }
        
    }
}
