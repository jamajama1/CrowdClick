using ApplicationCore.Entities;
using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;
using HtmlAgilityPack;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace Infrastucture.Services
{
    public class ScraperService : IScraperService
    {
        private readonly IProductRepository _productRepository;
        int count = 0;

        public ScraperService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<List<ProductResponseModel>> GetProductDetails(string url)
        {
            (int qty, string size) small = (0, "");
            (int qty, string size) medium = (0, "");
            (int qty, string size) large = (0, "");
            (int qty, string size) xLarge = (0, "");
            (int qty, string size) xxLarge = (0, "");

            var list = getProductLinks(url);

            foreach (var link in list)
            {

                var web = new HtmlWeb(); // Init the HTMl Web

                var doc = web.Load(link);

                if (doc.ParseErrors != null)
                { // Check for any errors and deal with it. 
                }


                /*var htmlNodes = doc.DocumentNode.Descendants("ul").Where(node=>node.GetAttributeValue("class", "").Equals("product")).ToList(); // Access the dom.
                var products = htmlNodes[0].Descendants("li").Where(node=>node.GetAttributeValue("class", "").Equals("product"));*/

                //var nodes = doc.DocumentNode.SelectNodes("//ul/li//article//div//figure//a//div//span//img").First().Attributes["data-src"].Value;

                var pic = doc.DocumentNode.SelectNodes("//html//body//div//div//div//img").Select(n => n.Attributes["src"].Value).ToList();
                var image = pic[2];

                var nodes = doc.DocumentNode.SelectNodes("//html//body//div//div//div//div//div//div//section").Select(n => n.InnerText.ToString());//.Select(m => m.Attributes["productView-title"].Value).ToList();

                var ProductDetails = nodes.ElementAt(0).Split('\n');
                var name = ProductDetails[162].TrimStart(' ');

                var price = Convert.ToDecimal(RemoveWhitespace(ProductDetails[266]).TrimStart('$'));
                //FIX PROBLEM WITH $20-$26
                var recommended = /*Convert.ToDecimal(*/RemoveWhitespace(ProductDetails[268]).TrimStart('$');//);
                var MOQmetadata = RemoveWhitespace(ProductDetails[270]).Split(new string[] { "pcs" }, StringSplitOptions.None);
                var MOQtype = MOQmetadata[1].TrimStart('(').TrimEnd(')');
                count++;

                var MOQ = 0;
                if (MOQmetadata[0] != "")
                {
                    MOQ = Convert.ToInt32(MOQmetadata[0]);
                }
                else
                {
                    var ParseMOQ = MOQtype.Split(new string[] { "," }, StringSplitOptions.None);
                    var count = 0;
                    foreach (var moq in ParseMOQ)
                    {
                        var countMOQ = moq.Split(new string[] { "*" }, StringSplitOptions.None);
                        count += Convert.ToInt32(countMOQ[0]);
                    }

                    MOQ = count;
                }

                if (name.Contains("pcs"))
                {
                    name = name.Substring(0, name.LastIndexOf("("));
                }

                if (name.Contains(";"))
                {
                    name = HttpUtility.HtmlDecode(name);
                }

                if (MOQtype != null)
                {
                    var MOQSplit = MOQtype.Split(new string[] { "," }, StringSplitOptions.None);
                    small = small;
                }
                

                if (!name.Contains("Random Pack"))
                {
                    var product = new Product
                    {
                        Name = name,
                        Price = price,
                        MinimumOrderQuantity = MOQ,
                        VendorId = 1,
                        Discontinued = false,
                        PicUrl = image,
                        ProductUrl = link,
                        SuggestedPrice = recommended,
                        
                    };

                    var e = await _productRepository.Add(product);
                }
            }

            return null;
        }

        public List<string> getProductLinks(string url)
        {
            var web = new HtmlWeb(); // Init the HTMl Web

            var doc = web.Load(url);
            var anchors = doc.DocumentNode.SelectNodes("//article//div//figure/a");
            var links = anchors.Select(a => a.Attributes["href"].Value).ToList();
            //var nodes = doc.DocumentNode.SelectNodes("//html//body//div//div//div//main//div//form//ul//li//article//div//figure").Select(m => m.Attributes["href"].Value).ToList();
            return links;
        }

        public string RemoveWhitespace(string input)
        {
            return new string(input.ToCharArray().Where(c => !Char.IsWhiteSpace(c)).ToArray());
        }

        public (int, string) MOQFix(string[] input)
        {
            (int, string) r = (0, "");

            foreach (var i in input)
            {
                
            }
            return r;
        }
    }
}
