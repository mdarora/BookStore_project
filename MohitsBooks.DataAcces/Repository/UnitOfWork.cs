using MohitsBooks.DataAcces.Repository.IRepository;
using MohitsBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MohitsBooks.DataAcces.Repository
{
    class UnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            SP_Call = new SP_Call(_db);
        }

        public ICategoryRepository Category { get; private set; }
        public SP_Call SP_Call { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
