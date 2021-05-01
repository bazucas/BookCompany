using BookCompany.Models;

namespace BookCompany.DAL.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}
