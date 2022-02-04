using ApplicationCore.Entities;
using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.RepositoryInterfaces
{
    public interface IProductRepository: IAsyncRepository<Product>
    {
        public Task<Product> GetProductByName(string product, int id, decimal price);
    }
}
