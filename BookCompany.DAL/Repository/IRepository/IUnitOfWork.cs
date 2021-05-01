using System;

namespace BookCompany.DAL.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        ISP_Call SP_Call { get; }
        void Save();
    }
}
