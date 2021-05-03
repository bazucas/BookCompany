using System.Linq;
using BookCompany.DAL.Data;
using BookCompany.DAL.Repository.IRepository;
using BookCompany.Models;

namespace BookCompany.DAL.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private readonly ApplicationDbContext _db;

        public CompanyRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Company company)
        {
            _db.Update(company);
        }
    }
}
