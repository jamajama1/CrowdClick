using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IProductService
    {
        public Task<List<ProductResponseModel>> GetProducts();
        public Task<ProductResponseModel> GetProductByName(string productName, int id, decimal price);
    }
}
