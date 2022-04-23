using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEB1.Api.Interfaces.Infrastructure;
using WEB1.Core.Entities;
using WEB1.Core.Interfaces.Service;

namespace WEB1.Core.Service
{
    public class ProductService : BaseService<Product>, IProductService
    {
        #region Fields
        IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository):base(productRepository)
        {
            _productRepository = productRepository;
        }
        #endregion
        #region Constructor

        #endregion
        #region Methods

        //public int? InsertService(Product product)
        //{
        //    var isValid = true;
        //    //Validate dữ liệu:

        //    //Thêm mới dữ liệu vào database
        //    if(isValid)
        //    {
        //        return _productRepository.Insert(product);
        //    }
        //    else
        //    {
        //        //trả về thông tin lỗi nghiệp vụ
        //        throw new NotImplementedException();
        //    }
            
        //}

        //public int? UpdateService(Product product, Guid productId)
        //{
        //    throw new NotImplementedException();
        //}
        #endregion

    }
}
