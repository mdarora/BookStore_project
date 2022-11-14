using System;
using System.Collections.Generic;
using System.Text;

namespace MohitsBooks.DataAcces.Repository.IRepository
{

    interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        ISP_Call SP_Call { get; }
    }
}
