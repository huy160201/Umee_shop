using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEB1.Core.Interfaces.Service
{
    public interface IBaseService<UmeeEntity>
    {
        /// <summary>
        /// Xử lý nghiệp vụ thêm mới dữ liệu
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Số bản ghi thêm mới thành công</returns>
        /// CreatedBy: NDHuy (20/04/2022)
        int? InsertService(UmeeEntity entity);
        int? UpdateService(UmeeEntity entity, Guid entityId);
    }
}
