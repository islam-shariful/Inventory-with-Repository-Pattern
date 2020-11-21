using Inventory_with_Repository_Pattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory_with_Repository_Pattern.Repositories
{
    public class ProductRepository : Repository<Product>
    {
        public List<Product> GetTopProducts(int top)
        {
            //return this.context.Products.OrderBy(x => x.Price).Take(2).ToList();
            return this.GetAll().OrderByDescending(x => x.Price).Take(top).ToList();
        }
    }
}