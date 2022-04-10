using WEB1.Core.Entities;

namespace WEB1.Api.Interfaces.Infrastructure
{
    /// <summary>
    /// Interface sử dụng cho sản phẩm
    /// CreatedBy: NDHuy (02/04/2022)
    /// </summary>
    public interface IProductRepository
    {
        /// <summary>
        /// Lấy toàn bộ danh sách sản phẩm
        /// </summary>
        /// <returns></returns>
        /// CreatedBy: NDHuy (02/04/2022)
        IEnumerable<Object> GetProducts();

        /// <summary>
        /// Thêm mới sản phẩm
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        /// CreatedBy: NDHuy (02/04/2022)
        int Insert(Product product);

        /// <summary>
        /// Cập nhật sản phẩm
        /// </summary>
        /// <param name="product"></param>
        /// <param name="productId"></param>
        /// <returns></returns>
        /// CreatedBy: NDHuy (02/04/2022)
        int Update(Product product, Guid productId);

        /// <summary>
        ///  Xóa sản phẩm theo id
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        /// CreatedBy: NDHuy (02/04/2022)
        int Delete(Guid productId);

        /// <summary>
        /// Lấy sản phẩm theo Id
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        /// CreatedBy: NDHuy (08/04/2022)
        Product GetProduct(Guid productId);
    }
}
