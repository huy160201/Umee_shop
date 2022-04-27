using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEB1.Core.Exceptions;
using WEB1.Core.Interfaces.Infrastructure;
using WEB1.Core.Interfaces.Service;
/// <summary>
/// Base controller
/// CreatedBy: NDHuy(25/04/2022)
/// </summary>
namespace WEB1.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BaseController<UmeeEntity> : ControllerBase
    {
        IBaseService<UmeeEntity> _baseService;
        IBaseRepository<UmeeEntity> _baseRepository;

        public BaseController(IBaseService<UmeeEntity> baseService, IBaseRepository<UmeeEntity> baseRepository)
        {
            _baseService = baseService;
            _baseRepository = baseRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var data = _baseRepository.Get();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var data = _baseRepository.Get(id);
            return Ok(data);
        }

        [HttpPost]
        public IActionResult Post(UmeeEntity entity)
        {
            var res = _baseService.InsertService(entity);
            if(res > 0)
                return StatusCode(201, res);
            return Ok(res);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var res = _baseRepository.Delete(id);
            if (res > 0)
                return StatusCode(201, res);
            return Ok(res);
        }

        [HttpPut("{id}")]
        public IActionResult Update(UmeeEntity entity, Guid id)
        {
            var res = _baseService.UpdateService(entity, id);
            if (res > 0)
                return StatusCode(201, res);
            return Ok(res);
        }
    }
}
