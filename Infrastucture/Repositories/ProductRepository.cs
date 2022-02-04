using ApplicationCore.Entities;
using ApplicationCore.RepositoryInterfaces;
using Infrastructure.Repositories;
using Infrastucture.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastucture.Repositories
{
    public class ProductRepository: EfRepository<Product>, IProductRepository
    {
        public ProductRepository(CrowdClickDbContext dbContext): base(dbContext)
        {

        }

        public async Task<Product> GetProductByName(string productName, int id, decimal price)
        {
            var product = await _dbContext.Products.FindAsync(productName, id, price);

            return product;
        }
    }
}
