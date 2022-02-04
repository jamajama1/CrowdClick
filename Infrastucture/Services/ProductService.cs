using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastucture.Services
{
    public class ProductService: IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<ProductResponseModel> GetProductByName(string productName, int id, decimal price)
        {
            var product = await _productRepository.GetProductByName(productName, id, price);

            var productResponse = new ProductResponseModel 
            {
                Name = product.Name,
                MOQ = product.MinimumOrderQuantity,                
                PicUrl = product.PicUrl,
                Price = product.Price
            };

            return productResponse;
        }

        public async Task<List<ProductResponseModel>> GetProducts()
        {
            //call product repos and get products
            var products = await _productRepository.GetAll();
            var productsList = products.Select(p=> new ProductResponseModel {  
                Name = p.Name, 
                PicUrl = p.PicUrl,
                MOQ = p.MinimumOrderQuantity,
                Price = p.Price
            }).ToList();

            return productsList;
        }
    }
}
