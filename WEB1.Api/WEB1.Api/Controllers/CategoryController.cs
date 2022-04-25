using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEB1.Core.Entities;
using WEB1.Core.Exceptions;
using WEB1.Core.Interfaces.Infrastructure;
using WEB1.Core.Interfaces.Service;

namespace WEB1.Api.Controllers
{
    public class CategoryController : BaseController<Category>
    {
        public CategoryController(ICategoryRepository categoryRepository, ICategoryService categoryService):base(categoryService, categoryRepository)
        {

        }
        
    }
}
