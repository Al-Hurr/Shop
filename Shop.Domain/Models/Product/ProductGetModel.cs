using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Models
{
    public class ProductGetModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }

        public async Task<Product> ToEntity()
        {
            return new Product
            {
                Name = this.Name,
                Description = this.Description,
                Value = this.Value
            };
        }
    }
}
