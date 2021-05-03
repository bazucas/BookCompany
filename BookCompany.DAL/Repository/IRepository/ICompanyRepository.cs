using BookCompany.Models;

namespace BookCompany.DAL.Repository.IRepository
{
    public interface ICompanyRepository : IRepository<Company>
    {
        void Update(Company company);
    }
}
