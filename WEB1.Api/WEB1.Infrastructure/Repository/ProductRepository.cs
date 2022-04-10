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
    public class ProductRepository : IProductRepository
    {
        public int Delete(Guid productId)
        {
            // khai báo thông tin kết nối
            var connectionString = "Server=localhost; " +
                "Port=3306;" +
                "Database=website_bandan_umee;" +
                "User Id=ndhuy" +
                "Password=mgmepgmfte";
            // khởi tạo kết nối
            MySqlConnection sqlConnection = new MySqlConnection(connectionString);
            // sql
            var sqlCommand = "DELETE FROM product WHERE ProductId = @ProductId";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ProductId", productId);
            // thực thi truy vấn
            var res = sqlConnection.Execute(sqlCommand,param: parameters);
            // trả về kết quả truy vấn
            return res;
        }
        public Product GetProduct(Guid productId)
        {
            // khai báo thông tin kết nối
            var connectionString = "Server=localhost; " +
                "Port=3306;" +
                "Database=website_bandan_umee;" +
                "User Id=ndhuy" +
                "Password=mgmepgmfte";
            // khởi tạo kết nối
            MySqlConnection sqlConnection = new MySqlConnection(connectionString);
            // lấy dữ liệu từ database
            var sqlCommand = "SELECT * FROM product WHERE ProductId = @ProductId";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ProductId", productId);
            // thực thi truy vấn
            var product = sqlConnection.QueryFirstOrDefault<Product>(sqlCommand, param: parameters);
            // trả về dữ liệu
            return product;
        }

        public IEnumerable<Product> GetProducts()
        {
            // khai báo thông tin kết nối
            var connectionString = "Server=localhost; " +
                "Port=3306;" +
                "Database=website_bandan_umee;" +
                "User Id=ndhuy" +
                "Password=mgmepgmfte";
            // khởi tạo kết nối
            MySqlConnection sqlConnection = new MySqlConnection(connectionString);
            // lấy dữ liệu từ database
            var sqlCommand = "SELECT * FROM product";
            // thực thi truy vấn
            var products = sqlConnection.Query<Product>(sqlCommand);
            // trả về dữ liệu
            return products;
        }

        public int Insert(Product product)
        {
            // sinh id cho đối tượng
            product.ProductId = Guid.NewGuid();
            // khai báo thông tin kết nối
            var connectionString = "Server=localhost; " +
                "Port=3306;" +
                "Database=website_bandan_umee;" +
                "User Id=ndhuy" +
                "Password=mgmepgmfte";
            // khởi tạo kết nối
            MySqlConnection sqlConnection = new MySqlConnection(connectionString);
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

        public int Update(Product product, Guid productId)
        {
            throw new NotImplementedException();
        }
    }
}
