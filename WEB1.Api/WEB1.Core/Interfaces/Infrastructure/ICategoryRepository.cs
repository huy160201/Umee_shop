using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEB1.Core.Entities;

namespace WEB1.Core.Interfaces.Infrastructure
{
    /// <summary>
    /// interface thể loại sản phẩm
    /// CreatedBy: NDHuy (12/04/2022)
    /// </summary>
    public interface ICategoryRepository
    {
        /// <summary>
        /// Lấy dữ liệu
        /// </summary>
        /// <returns>tất cả bản ghi thể loại</returns>
        IEnumerable<object> Get();
        /// <summary>
        /// lấy dữ liệu
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns>lấy thể loại với Id truyền vào</returns>
        Object Get(Guid categoryId);
        /// <summary>
        /// thêm mới bản ghi
        /// </summary>
        /// <param name="category"></param>
        /// <returns>số bản ghi thêm được</returns>
        int Insert(Category category);
        /// <summary>
        /// cập nhật bản ghi
        /// </summary>
        /// <param name="category"></param>
        /// <param name="categoryId"></param>
        /// <returns>số bản ghi cập nhật được</returns>
        int Update(Category category, Guid categoryId);
        /// <summary>
        /// xóa bản ghi
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns>số bản ghi bị xóa</returns>
        int Delete(Guid categoryId);
    }
}
