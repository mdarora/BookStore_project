using System;
using MohitsBooks.DataAcces.Repository;
using MohitsBookStore.DataAccess.Data;
using System.Collections.Generic;
using System.Text;

namespace MohitsBooks.DataAcces.Repository.IRepository
{

    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        ISP_Call SP_Call { get; }

        void save();
    }
}
