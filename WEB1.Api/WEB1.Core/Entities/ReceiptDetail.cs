using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEB1.Core.UmeeAttribute;

namespace WEB1.Core.Entities
{
    /// <summary>
    /// Chi tiết đơn hàng
    /// CreatedBy: NDHuy (08/04/2022)
    /// </summary>
    public class ReceiptDetail
    {
        #region Property
        /// <summary>
        /// Khóa ngoại, Mã đơn hàng
        /// </summary>
        [ForeignKey]
        public Guid OrderId { get; set; }

        /// <summary>
        /// Khóa ngoại, mã sản phẩm
        /// </summary>
        [ForeignKey]
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
