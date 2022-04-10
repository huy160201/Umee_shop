using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEB1.Core.Entities
{
    /// <summary>
    /// Thông tin đơn hàng
    /// CreatedBy: NDHuy (08/04/2022)
    /// </summary>
    public class Order
    {
        #region Property
        /// <summary>
        /// khóa chính đơn hàng - id
        /// </summary>
        public Guid OrderId { get; set; }
        /// <summary>
        /// khóa ngoại - tài khoản đặt đơn
        /// </summary>
        public Guid AccountId { get; set; }
        /// <summary>
        /// ngày tạo đơn
        /// </summary>
        public DateTime CreatedAt { get; set; }
        /// <summary>
        /// trạng thái đơn, 0 - chưa duyệt, 1 - đã duyệt
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// phí vận chuyển
        /// </summary>
        public int TransportFee { get; set; }
        /// <summary>
        /// tên người nhận
        /// </summary>
        public string ReceiverName { get; set; }
        /// <summary>
        /// địa chỉ nhận
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// số điện thoại người nhận
        /// </summary>
        public int PhoneNumber { get; set; }
        #endregion

    }
}
