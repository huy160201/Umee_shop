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
        public Admin Admin { get; set; }
        /// <summary>
        /// Xử lý Enum cho Admin
        /// </summary>
        public string AdminName
        {
            get
            {
                switch (Admin)
                {
                    case Enum.Admin.Customer:
                        return Properties.Resources.Enum_Customer;
                    case Enum.Admin.Admin:
                        return Properties.Resources.Enum_Admin;
                    default:
                        return Properties.Resources.Enum_Customer;
                }    
            }
        }
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
        public Gender Gender { get; set; }
        /// <summary>
        /// Xử lý Enum cho Gender
        /// </summary>
        public string GenderName
        {
            get
            {
                switch (Gender)
                {
                    case Enum.Gender.Male:
                        return Properties.Resources.Enum_Male;
                    case Enum.Gender.Female:
                        return Properties.Resources.Enum_Female;
                    default:
                        return Properties.Resources.Enum_Male;
                }
            }
        }
        #endregion

    }
}
