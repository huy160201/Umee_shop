using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEB1.Core.Interfaces.Infrastructure
{
    /// <summary>
    /// Base interface
    /// CreatedBy: NDHuy (16/04/2022)
    /// </summary>
    /// <typeparam name="UmeeEntity"></typeparam>
    public interface IBaseRepository<UmeeEntity>
    {
        /// <summary>
        /// Trả về tất cả số bản ghi
        /// </summary>
        /// <returns>Tất cả số bản ghi</returns>
        IEnumerable<Object> Get();

        /// <summary>
        /// Thêm mới bản ghi
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Số bản ghi thêm được</returns>
        int Insert(UmeeEntity entity);

        /// <summary>
        /// Cập nhật bản ghi
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="entityId"></param>
        /// <returns>Số bản ghi cập nhật được</returns>
        int Update(UmeeEntity entity, Guid entityId);

        /// <summary>
        /// Xóa bản ghi
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns>Số bản ghi xóa được</returns>
        int Delete(Guid entityId);

        /// <summary>
        /// Lấy bản ghi theo Id
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns>Bản ghi tương ứng với Id</returns>
        object Get(Guid entityId);
    }
}
