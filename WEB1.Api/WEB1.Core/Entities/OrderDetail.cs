using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEB1.Core.Entities
{
    /// <summary>
    /// Chi tiết đơn hàng
    /// CreatedBy: NDHuy (08/04/2022)
    /// </summary>
    public class OrderDetail
    {
        #region Property
        /// <summary>
        /// Khóa ngoại, Mã đơn hàng
        /// </summary>
        public Guid OrderId { get; set; }
        /// <summary>
        /// Khóa ngoại, mã sản phẩm
        /// </summary>
        public Guid ProductId { get; set; }
        /// <summary>
        /// Giá đơn hàng
        /// </summary>
        public int Price { get; set; }
        /// <summary>
        /// Số lượng đặt mua
        /// </summary>
        public int Amount { get; set; }
        #endregion
    }
}
