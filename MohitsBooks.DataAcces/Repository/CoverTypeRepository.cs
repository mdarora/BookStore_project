using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using MohitsBooks.Models;
using MohitsBooks.DataAcces.Repository.IRepository;
using MohitsBookStore.DataAccess.Data;

namespace MohitsBooks.DataAcces.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;
        public CoverTypeRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }
        public void Update(CoverType coverType)
        {
            var objFromDb = _db.CoverTypes.FirstOrDefault(s => s.Id == coverType.Id);
            if(objFromDb != null)
            {
                objFromDb.Name = coverType.Name;
            }
        }
    }
}
