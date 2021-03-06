using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEB1.Core.Exceptions;
using WEB1.Core.Interfaces.Infrastructure;
using WEB1.Core.Interfaces.Service;
using WEB1.Core.UmeeAttribute;

namespace WEB1.Core.Service
{
    public class BaseService<UmeeEntity> : IBaseService<UmeeEntity>
    {
        // khai báo thông tin lỗi
        List<string> errorMsgs = new List<string>();

        IBaseRepository<UmeeEntity> _baseRepository;
        public BaseService(IBaseRepository<UmeeEntity> baseRepository)
        {
            _baseRepository = baseRepository;
        }
        public int? InsertService(UmeeEntity entity)
        {
            var isValid = ValidateObject(entity);
            if (isValid)
            {
                isValid = ValidateCustom(entity);
            }
            // validate dữ liệu
            if(isValid)
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
                // lấy ra các prop được định nghĩa NotEmpty
            var propsNotEmpty = entity.GetType().GetProperties().Where(prop=>Attribute.IsDefined(prop, typeof(NotEmpty)));
            foreach (var prop in propsNotEmpty)
            {
                var propValue = prop.GetValue(entity);
                if (propValue == null || string.IsNullOrEmpty(propValue.ToString()))
                    errorMsgs.Add(Properties.Resources.NotEmptyException + $"{prop.Name}");

            }
            // check trùng lặp dữ liệu: 
                // lấy ra các prop được định nghĩa NotEmpty
            var propsNotDuplicate = entity.GetType().GetProperties().Where(prop => Attribute.IsDefined(prop, typeof(NotDuplicate)));
            foreach (var prop in propsNotDuplicate)
            {
                // truy cập database kiểm tra mã có trùng lặp hay không
                var isDuplicate = _baseRepository.CheckDuplicate(prop.Name, prop.GetValue(entity));
                if(isDuplicate)
                    errorMsgs.Add(Properties.Resources.NotDuplicateException + $"{prop.Name}");
            }
            // check định dạng dữ liệu: 

            if (errorMsgs.Count > 0)
            {
                isValid = false;
                var result = new
                {
                    userMsg = Properties.Resources.ValidateException,
                    data = errorMsgs
                };
                throw new UmeeValidateException(result);
            }
            return isValid;
        }
        /// <summary>
        /// Hàm validate đặc thù cho từng đối tượng khác nhau
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>>true -> dữ liệu hợp lệ, false -> ngược lại</returns>
        /// CreatedBy: NDHuy (25/04/2022)
        protected virtual bool ValidateCustom(UmeeEntity entity)
        {
            return true;
        }
    }
}
