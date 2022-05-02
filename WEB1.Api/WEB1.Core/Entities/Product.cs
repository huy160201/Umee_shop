using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEB1.Core.UmeeAttribute;

namespace WEB1.Core.Entities
{
    /// <summary>
    /// Thông tin sản phẩm
    /// CreatedBy: NDHuy (02/04/2022)
    /// </summary>
    public class Product
    {
        #region Property
        /// <summary>
        /// Khóa chính
        /// </summary>
        [PrimaryKey]
        public Guid ProductId { get; set; }

        /// <summary>
        /// Thể loại sản phẩm
        /// </summary>
        [NotEmpty]
        [ForeignKey]
        public Guid CategoryId { get; set; }

        /// <summary>
        /// Tên sản phẩm
        /// </summary>
        [NotEmpty]
        [NotDuplicate]
        public string ProductName { get; set; }

        /// <summary>
        /// Giá sản phẩm
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// Số lượng sản phẩm trong kho
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// Số lượng đã bán
        /// </summary>
        public int AmountSold { get; set; }

        /// <summary>
        /// Mô tả sản phẩm
        /// </summary>
        public string Content { get; set; }
        #endregion

    }
}
