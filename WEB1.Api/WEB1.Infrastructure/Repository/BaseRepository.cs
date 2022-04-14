using MySqlConnector;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEB1.Infrastructure.Repository
{
    /// <summary>
    /// Base Repository
    /// CreatedBy: NDHuy (12/04/2022)
    /// </summary>
    public class BaseRepository
    {
        // Khai báo thông tin kết nối: 
        protected string connectionString = "Server = localhost; " +
                                "Port=3306; " +
                                "Database = website_bandan_umee;" +
                                "User Id= ndhuy;" +
                                "Password=mgmepgmfte";
        protected MySqlConnection sqlConnection;

        protected IEnumerable<object> Get<UmeeEntity>()
        {
            using(sqlConnection = new MySqlConnection(connectionString))
            {
                var tableName = typeof(UmeeEntity).Name;
                // lấy dữ liệu:
                var sqlCommand = $"SELECT * FROM {tableName}";
                var entities = sqlConnection.Query<object>(sql: sqlCommand);
                // trả về số bản ghi
                return entities;
            }
        }

        protected object Get<UmeeEntity>(Guid entityId)
        {
            using (sqlConnection = new MySqlConnection(connectionString))
            {
                var tableName = typeof(UmeeEntity).Name;
                // lấy dữ liệu:
                var sqlCommand = $"SELECT * FROM {tableName} WHERE {tableName}Id = @{tableName}Id";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add($"@{tableName}Id", entityId);
                var entity = sqlConnection.QueryFirstOrDefault<object>(sql: sqlCommand, param: parameters);
                // trả về số bản ghi
                return entity;
            }
        }

        protected int Insert<UmeeEntity>(UmeeEntity entity)
        {
            using (sqlConnection = new MySqlConnection(connectionString))
            {
                //Lấy tên của class tương ứng tableName trong dtb
                var tableName = typeof(UmeeEntity).Name;
                var listColumnNames = string.Empty;
                var listColumnParam = string.Empty;
                                                            
                var parameters = new DynamicParameters();
                //1, duyệt từng prop của object
                var props = typeof(UmeeEntity).GetProperties();
                foreach (var prop in props)
                {
                    // lấy tên của property
                    var propName = prop.Name;

                    // lấy giá trị của property
                    var propValue = prop.GetValue(entity);

                    // từ tên, giá trị của prop -> build câu lệnh truy vấn, add param cho parameters
                    listColumnNames += $"{propName},";
                    listColumnParam += $"@{propName},";
                    parameters.Add($"@{propName}", propValue);
                }
                //2, loại bỏ dấu phẩy ở cuối list
                listColumnNames = listColumnNames.Substring(0, listColumnNames.Length - 1);
                listColumnParam = listColumnParam.Substring(0, listColumnParam.Length - 1);
                //3, Khai báo câu lệnh Insert
                var sqlCommand = $"INSERT INTO {tableName}({listColumnNames}) VALUES ({listColumnParam})";

                var rowInserts = sqlConnection.Execute(sql: sqlCommand, param: parameters);
                return rowInserts;
            }
        }   
        
        protected int Delete<UmeeEntity>(Guid entityId)
        {
            // lấy ra tên table
            var tableName = typeof(UmeeEntity).Name;
            //xóa dữ liệu
            var sqlCommand = $"DELETE FROM {tableName} WHERE {tableName}Id = @{tableName}Id";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add($"@{tableName}Id", entityId);
            var res = sqlConnection.Execute(sql: sqlCommand, param: parameters);

            return res;
        }    
    }
}
