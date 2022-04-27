using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEB1.Core.Enum;
using WEB1.Core.UmeeAttribute;

namespace WEB1.Core.Entities
{
    /// <summary>
    /// Thông tin đơn hàng
    /// CreatedBy: NDHuy (08/04/2022)
    /// </summary>
    public class Receipt
    {
        #region Property
        /// <summary>
        /// khóa chính đơn hàng - id
        /// </summary>
        [PrimaryKey]
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
        public Status Status { get; set; }

        public string StatusName
        {
            get
            {
                switch (Status)
                {
                    case Enum.Status.Unaccept:
                        return Properties.Resources.Enum_Status_Unaccept;
                    case Enum.Status.Accept:
                        return Properties.Resources.Enum_Status_Accept;
                    default:
                        return Properties.Resources.Enum_Status_Unaccept;
                }
            }
        }
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
