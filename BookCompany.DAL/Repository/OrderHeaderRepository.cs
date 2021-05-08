using BookCompany.DAL.Data;
using BookCompany.DAL.Repository.IRepository;
using BookCompany.Models;

namespace BookCompany.DAL.Repository
{
    public class OrderHeaderRepository : Repository<OrderHeader>, IOrderHeaderRepository
    {
        private readonly ApplicationDbContext _db;

        public OrderHeaderRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(OrderHeader obj)
        {
            _db.Update(obj);
        }
    }
}
