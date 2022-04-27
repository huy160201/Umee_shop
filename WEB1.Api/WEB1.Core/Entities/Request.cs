using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEB1.Core.UmeeAttribute;

namespace WEB1.Core.Entities
{
    /// <summary>
    /// Câu hỏi của khách hàng
    /// CreatedBy: NDHuy (10/04/2022)
    /// </summary>
    public class Request
    {
        #region Property
        /// <summary>
        /// Khóa chính, mã câu hỏi
        /// </summary>
        [PrimaryKey]
        public Guid RequestId { get; set; }
        /// <summary>
        /// Họ tên khách
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// Số điện thoại
        /// </summary>
        public int PhoneNumber { get; set; }
        /// <summary>
        /// Nội dung
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// Ngày diễn ra
        /// </summary>
        public DateOnly CreatedAt { get; set; }
        #endregion
    }
}
