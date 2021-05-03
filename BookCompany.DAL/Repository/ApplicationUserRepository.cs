using System.Linq;
using BookCompany.DAL.Data;
using BookCompany.DAL.Repository.IRepository;
using BookCompany.Models;

namespace BookCompany.DAL.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private readonly ApplicationDbContext _db;

        public ApplicationUserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
