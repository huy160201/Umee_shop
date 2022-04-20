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
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {

    }
}
