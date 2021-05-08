using BookCompany.Models.ViewModels;

namespace BookCompany.DAL.Repository.IRepository
{
    public interface IOrderDetailsRepository : IRepository<OrderDetails>
    {
        void Update(OrderDetails obj);
    }
}
