using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.WebApp.Models
{
    public class ProductModel
    {
        public string ProductID {get; set;}
        public string Name       {get; set;}
        public string Brand      {get; set;}
        public string Price { get; set; }

        public ProductModel()
        {
            ProductID = "sdjfhskf";
            Name = "sjfsdfhds";
            Brand = "sdhfdsjfd";
            Price = "sdgfdsg";
        }

    }
    
}
