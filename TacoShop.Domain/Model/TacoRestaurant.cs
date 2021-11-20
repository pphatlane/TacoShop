using System;
using System.Collections.Generic;
using System.Text;

namespace TacoShop.Domain.Model
{
    public class TacoRestaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Suburb { get; set; }
        public string LogoPath { get; set; }
        public int Rank { get; set; }
        public List<Categories> Categories { get; set; }
    }
}
