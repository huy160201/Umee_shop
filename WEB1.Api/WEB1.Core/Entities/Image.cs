using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEB1.Core.Entities
{
    /// <summary>
    /// thông tin ảnh 
    /// CreatedBy: NDHuy (10/04/2022)
    /// </summary>
    public class Image
    {
        #region Property
        /// <summary>
        /// Khóa chính, mã ảnh
        /// </summary>
        public Guid ImageId { get; set; }
        /// <summary>
        /// Khóa ngoại, mã sản phẩm
        /// </summary>
        public Guid ProductId { get; set; }
        /// <summary>
        /// Đường dẫn ảnh
        /// </summary>
        public string Url { get; set; }
        #endregion
    }
}
