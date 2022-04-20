using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEB1.Core.UmeeAttribute;

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
        [PrimaryKey]
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
