using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEB1.Core.Interfaces.Infrastructure;
using WEB1.Core.Interfaces.Service;

namespace WEB1.Core.Service
{
    public class BaseService<UmeeEntity> : IBaseService<UmeeEntity>
    {
        IBaseRepository<UmeeEntity> _baseRepository;
        public BaseService(IBaseRepository<UmeeEntity> baseRepository)
        {
            _baseRepository = baseRepository;
        }
        public int? InsertService(UmeeEntity entity)
        {
            // validate dữ liệu
            if(ValidateObject(entity) == true)
            {
                // thêm mới dữ liệu vào dtb
                var res = _baseRepository.Insert(entity);
                return res;
            }
            return null;
        }

        public int? UpdateService(UmeeEntity entity, Guid entityId)
        {
            // validate dữ liệu

            // thêm mới dữ liệu vào dtb
            var res = _baseRepository.Update(entity, entityId);
            return res;
        }

        /// <summary>
        /// Hàm thực hiện validate
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>true -> dữ liệu hợp lệ, false -> ngược lại</returns>
        /// CreatedBy: NDHuy (20/04/2022)
        private bool ValidateObject(UmeeEntity entity)
        {
            var isValid = true;
            // validate chung:

            // dữ liệu bắt buộc: 

            // check trùng lặp dữ liệu: 

            // check định dạng dữ liệu: 

            return isValid;
        }
    }
}
