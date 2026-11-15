using OOP301EF.DataAccessLayer.Abstract;
using OOP301EF.DataAccessLayer.Context;
using OOP301EF.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP301EF.DataAccessLayer.Repositories
{
    public class EFProductDal : GenericRepository<Product>, IProductDal
    {
        public List<Object> GetProductsWithCategory()
        {
            var context = new CampContext();
            var values = context.Products
                .Select(x => new 
                {
                    ProductId = x.ProductId,
                    ProductDescription = x.ProductDescription,
                    ProductName = x.ProductName,
                    ProductPrice = x.ProductPrice,
                    ProductStock = x.ProductStock,
                    CategoryName = x.Category.CategoryName

                }).ToList();
            return values.Cast<Object>().ToList();
        }
    }
}
