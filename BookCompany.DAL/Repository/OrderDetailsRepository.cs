using BookCompany.DAL.Data;
using BookCompany.DAL.Repository.IRepository;
using BookCompany.Models.ViewModels;

namespace BookCompany.DAL.Repository
{
    public class OrderDetailsRepository : Repository<OrderDetails>, IOrderDetailsRepository
    {
        private readonly ApplicationDbContext _db;

        public OrderDetailsRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(OrderDetails obj)
        {
            _db.Update(obj);
        }
    }
}
