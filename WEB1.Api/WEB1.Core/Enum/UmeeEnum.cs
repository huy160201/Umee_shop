using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEB1.Core.Enum
{
    /// <summary>
    /// Giới tính
    /// </summary>
    /// CreatedBy: NDHuy (27/04/2022)
    public enum Gender
    {
        /// <summary>
        /// Nam
        /// </summary>
        Male=0,

        /// <summary>
        /// Nữ
        /// </summary>
        Female=1
    }

    /// <summary>
    /// Phân quyền
    /// </summary>
    /// CreatedBy: NDHuy (27/04/2022)
    public enum Admin
    {
        /// <summary>
        /// Khách hàng
        /// </summary>
        Customer=0,

        /// <summary>
        /// Admin
        /// </summary>
        Admin=1
    }

    /// <summary>
    /// Trạng thái đơn hàng
    /// </summary>
    /// CreatedBy: NDHuy (27/04/2022)
    public enum Status
    {
        /// <summary>
        /// Chưa duyệt
        /// </summary>
        Unaccept=0,

        /// <summary>
        /// Đã duyệt
        /// </summary>
        Accept=1
    }
}
