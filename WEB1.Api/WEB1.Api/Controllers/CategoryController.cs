using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEB1.Core.Entities;
using WEB1.Core.Interfaces.Infrastructure;
using WEB1.Core.Interfaces.Service;

namespace WEB1.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        ICategoryRepository _categoryRepository;
        ICategoryService _categoryService;
        public CategoryController(ICategoryRepository categoryRepository, ICategoryService categoryService)
        {
            _categoryRepository = categoryRepository;
            _categoryService = categoryService;

        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var categories = _categoryRepository.Get();
                return Ok(categories);
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

        [HttpGet("{categoryId}")]
        public IActionResult Get(Guid categoryId)
        {
            try
            {
                var category = _categoryRepository.Get(categoryId);
                return Ok(category);
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
        public IActionResult Insert(Category category)
        {
            try
            {
                var res = _categoryService.InsertService(category);
                if (res > 0)
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

        [HttpDelete("{categoryId}")]
        public IActionResult Delete(Guid categoryId)
        {
            try
            {
                var res = _categoryRepository.Delete(categoryId);
                if (res > 0)
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

        [HttpPut("{categoryId}")]
        public IActionResult Update(Category category, Guid categoryId)
        {
            try
            {
                var res = _categoryService.UpdateService(category, categoryId);
                if (res > 0)
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
