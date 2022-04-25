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
            try
            {
                var data = _baseRepository.Get();
                return Ok(data);
            }
            catch (UmeeValidateException ex)
            {
                return StatusCode(400, ex.Data);
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

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            try
            {
                var data = _baseRepository.Get(id);
                return Ok(data);
            }
            catch (UmeeValidateException ex)
            {
                return StatusCode(400, ex.Data);
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
        public IActionResult Post(UmeeEntity entity)
        {
            try
            {
                var res = _baseService.InsertService(entity);
                if(res > 0)
                    return StatusCode(201, res);
                else
                    return Ok(res);
            }
            catch (UmeeValidateException ex)
            {
                return StatusCode(400, ex.Data);
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

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                var res = _baseRepository.Delete(id);
                if (res > 0)
                    return StatusCode(201, res);
                else
                    return Ok(res);
            }
            catch (UmeeValidateException ex)
            {
                return StatusCode(400, ex.Data);
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

        [HttpPut("{id}")]
        public IActionResult Update(UmeeEntity entity, Guid id)
        {
            try
            {
                var res = _baseService.UpdateService(entity, id);
                if (res > 0)
                    return StatusCode(201, res);
                else
                    return Ok(res);
            }
            catch (UmeeValidateException ex)
            {
                return StatusCode(400, ex.Data);
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
