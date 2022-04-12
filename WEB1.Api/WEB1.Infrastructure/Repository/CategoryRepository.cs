using Dapper;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEB1.Core.Entities;
using WEB1.Core.Interfaces.Infrastructure;

namespace WEB1.Infrastructure.Repository
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {      
        public int Delete(Guid categoryId)
        {
            using (sqlConnection = new MySqlConnection(connectionString))
            {
                // sql
                var sqlCommand = "DELETE FROM category WHERE CategoryId = @CategoryId";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@CategoryId", categoryId);
                // thực thi truy vấn
                var res = sqlConnection.Execute(sqlCommand, param: parameters);
                // trả về kết quả truy vấn
                return res;
            }
            
        }

        public IEnumerable<object> Get()
        {
            var categories = Get<Category>();
            return categories;
        }

        public Object Get(Guid categoryId)
        {
            var category = Get<Category>(categoryId);
            return category;
        }

        public int Insert(Category category)
        {
            using (sqlConnection = new MySqlConnection(connectionString))
            {
                category.CategoryId = Guid.NewGuid();
                var res = Insert<Category>(category);
                return res;
            }
            
        }

        public int Update(Category category, Guid categoryId)
        {
            using (sqlConnection = new MySqlConnection(connectionString))
            {
                //TODO: 

                //trả về kết quả:
                return 1;
            }
            
        }
    }
}
