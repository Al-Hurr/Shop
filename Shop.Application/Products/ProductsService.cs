using Shop.Database;
using Shop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Products
{
    public class ProductsService
    {
        private ApplicationDbContext _context;

        public ProductsService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Create(ProductGetModel model)
        {
            var product = await model.ToEntity();
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }
    }
}
