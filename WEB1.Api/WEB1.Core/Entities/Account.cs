using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEB1.Core.UmeeAttribute;

namespace WEB1.Core.Entities
{
    /// <summary>
    /// Thông tin tài khoản
    /// CreatedBy: NDHuy (08/04/2022)
    /// </summary>
    public class Account
    {
        #region Property
        /// <summary>
        /// Khóa chính tài khoản - id
        /// </summary>
        [PrimaryKey]
        public Guid AccountId { get; set; }
        /// <summary>
        /// Họ tên
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// Phân quyền, 0 - khách hàng, 1 - admin
        /// </summary>
        public int Admin { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Ngày tháng năm sinh
        /// </summary>
        public DateOnly DateOfBirth { get; set; }
        /// <summary>
        /// Giới tính, 0 - Nam, 1 - Nữ
        /// </summary>
        public int Gender { get; set; }
        #endregion

    }
}
