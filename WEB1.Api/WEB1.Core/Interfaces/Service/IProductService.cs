using WEB1.Core.Entities;

namespace WEB1.Core.Interfaces.Service
{
    /// <summary>
    /// Interface xử lý nghiệp vụ cho sản phẩm
    /// CreatedBy: NDHuy (02/04/2022)
    /// </summary>
    public interface IProductService
    {
        /// <summary>
        /// Xử lý nghiệp vụ thêm mới dữ liệu
        /// </summary>
        /// <param name="product"></param>
        /// <returns>Số bản ghi thêm mới thành công</returns>
        /// CreatedBy: NDHuy (03/04/2022)
        int InsertService(Product product);
        int UpdateService(Product product, Guid productId);
        int DeleteService(Guid productId);
    }
}
