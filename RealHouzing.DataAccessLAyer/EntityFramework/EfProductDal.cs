using Microsoft.EntityFrameworkCore;
using RealHouzing.DataAccessLAyer.Abstract;
using RealHouzing.DataAccessLAyer.Concrete;
using RealHouzing.DataAccessLAyer.Repositories;
using RealHouzing.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.DataAccessLAyer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public List<Product> GetProductsWithCategories()
        {
            using var context = new Context();
            return context.Products.Include(x=> x.Category).ToList();
        }
    }
}
