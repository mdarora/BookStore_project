using MohitsBooks.DataAcces.Repository.IRepository;
using MohitsBooks.Models;
using MohitsBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MohitsBooks.DataAcces.Repository
{
    public class ProductRepositry : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductRepositry(ApplicationDbContext db): base(db)
        {
            _db = db;
        }
    
        public void Update(Product product)
        {
            var objFromDb = _db.Products.FirstOrDefault(s => s.Id == product.Id);
            if (objFromDb != null)
            {
                if(product.ImageUrl != null)
                {
                    objFromDb.ImageUrl = product.ImageUrl;
                }
                objFromDb.Title = product.Title;
                objFromDb.Description = product.Description;
                objFromDb.ISBN = product.ISBN;
                objFromDb.Author = product.Author;
                objFromDb.ListPrice = product.ListPrice;
                objFromDb.CategoryId = product.CategoryId;
                objFromDb.CoverTypeId = product.CoverTypeId;
            }
        }
    }
}
