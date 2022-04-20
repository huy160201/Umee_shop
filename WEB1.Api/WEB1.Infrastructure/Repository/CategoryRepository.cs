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
    /// <summary>
    /// Repository thể loại
    /// CreatedBy: NHDhuy (14/04/2022)
    /// </summary>
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {      
        
    }
}
