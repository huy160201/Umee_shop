using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEB1.Core.UmeeAttribute;

namespace WEB1.Core.Entities
{
    /// <summary>
    /// Thông tin danh mục
    /// CreatedBy: NDHuy (02/04/2022)
    /// </summary>
    public class Category
    {
        #region Property
        /// <summary>
        /// Khóa chính 
        /// </summary>
        [PrimaryKey]
        public Guid CategoryId { get; set; }
        /// <summary>
        /// Tên thể loại
        /// </summary>
        public string CategoryName { get; set; }
        #endregion
    }
}
