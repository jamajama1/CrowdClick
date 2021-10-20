using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastucture.Services
{
    public class ProductService
    {
        public List<ProductResponseModel> GetProducts()
        {
            //call product repos and get products

            var products = new List<ProductResponseModel> { 
                new ProductResponseModel { Id=1, Title="TestProduct1", PosterUrl="https://sc04.alicdn.com/kf/H2a94aea1f4c44d918e6b8163a52a7026J.jpg" },
                new ProductResponseModel { Id=2, Title="TestProduct2", PosterUrl="https://sc04.alicdn.com/kf/H3acb6b4f84af48118d4c2ccbf95477d6Z.jpg" },
                new ProductResponseModel { Id=3, Title="TestProduct3", PosterUrl="https://sc04.alicdn.com/kf/Hbd8d3113f8724c14b8233de6e026eae9e.jpg" }
            };

            return products;
        }
    }
}
