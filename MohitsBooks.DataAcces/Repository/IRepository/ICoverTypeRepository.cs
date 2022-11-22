using MohitsBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MohitsBooks.DataAcces.Repository.IRepository
{
    public interface ICoverTypeRepository : IRepository<CoverType>
    {
        void Update(CoverType coverType);
    }
}
