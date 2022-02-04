using ApplicationCore.Entities;
using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IScraperService
    {
        public List<string> getProductLinks(string url);
        public Task<List<ProductResponseModel>> GetProductDetails(string url);
    }
}
