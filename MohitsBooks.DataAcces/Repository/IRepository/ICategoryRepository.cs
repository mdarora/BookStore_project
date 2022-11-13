using MohitsBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MohitsBooks.DataAcces.Repository.IRepository
{
    internal interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}
