using Dapper;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEB1.Api.Interfaces.Infrastructure;
using WEB1.Core.Entities;

namespace WEB1.Infrastructure.Repository
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public int Delete(Guid productId)
        {
            using (sqlConnection = new MySqlConnection(connectionString))
            {
                // sql
                var sqlCommand = "DELETE FROM product WHERE ProductId = @ProductId";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ProductId", productId);
                // thực thi truy vấn
                var res = sqlConnection.Execute(sqlCommand, param: parameters);
                // trả về kết quả truy vấn
                return res;
            }
                        
        }
        public object GetProduct(Guid productId)
        {
            var product = Get<Product>(productId);
            return product;
        }

        public IEnumerable<Object> GetProducts()
        {
            using (sqlConnection = new MySqlConnection(connectionString))
            {
                var products = Get<Product>();
                return products;
            }            
        }

        public int Insert(Product product)
        {
            using (sqlConnection = new MySqlConnection(connectionString))
            {
                // sinh id cho đối tượng
                product.ProductId = Guid.NewGuid();
                // sql
                var sqlCommand = "INSERT product (ProductId, CategoryId, ProductName, Amount, AmountSold, Content)" +
                                  "VALUES(@ProductId, @CategoryId, @ProductName, @Amount, @AmountSold, @Content); ";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ProductId", product.ProductId);
                parameters.Add("@CategoryId", product.CategoryId);
                parameters.Add("@ProductName", product.ProductName);
                parameters.Add("@Amount", product.Amount);
                parameters.Add("@AmountSold", product.AmountSold);
                parameters.Add("@Content", product.Content);
                // thực thi truy vấn
                var res = sqlConnection.Execute(sqlCommand, param: parameters);
                return res;
            }            
        }

        public int Update(Product product, Guid productId)
        {
            throw new NotImplementedException();
        }
    }
}
