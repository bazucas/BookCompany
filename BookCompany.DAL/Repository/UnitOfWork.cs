﻿using BookCompany.DAL.Data;
using BookCompany.DAL.Repository.IRepository;

namespace BookCompany.DAL.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public ICategoryRepository Category { get; private set; }
        public ISP_Call SP_Call { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            SP_Call = new SP_Call(_db);
        }

        public void Dispose()
        {
            _db?.Dispose();
            SP_Call?.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}