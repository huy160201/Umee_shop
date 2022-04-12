using WEB1.Core.Entities;

namespace WEB1.Core.Interfaces.Service
{
    public interface ICategoryService
    {
        int Insert(Category category);
        int Update(Category category, Guid categoryId);
    }
}
