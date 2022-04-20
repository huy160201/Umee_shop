using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEB1.Core.Entities;
using WEB1.Core.Interfaces.Infrastructure;
using WEB1.Core.Interfaces.Service;

namespace WEB1.Core.Service
{
    public class CategoryService : ICategoryService
    {
        ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public int? InsertService(Category category)
        {
            //TODO: validate dữ liệu:

            // thực hiện thêm mới dữ liệu vào database
            return _categoryRepository.Insert(category);
        }

        public int? UpdateService(Category category, Guid categoryId)
        {
            //TODO: validate dữ liệu:

            // thực hiện cập nhật dữ liệu trong database
            return _categoryRepository.Update(category, categoryId);
        }
    }
}
