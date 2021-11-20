using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using TacoShop.Domain.Interfaces.Repository;
using TacoShop.Domain.Model;

namespace TacoShop.Data.Repositories
{
    public class BuyRepository: IBuyRepository
    {
        public IEnumerable<TacoRestaurant> GetAllAvailableSearchedMenu()
        {
            //get searched menu
            var file = "SampleData.json";
            var stringJson = File.ReadAllText($@"..\..\Files\{file}");
            IEnumerable<TacoRestaurant> tacoRestaurant = JsonConvert.DeserializeObject<IEnumerable<TacoRestaurant>>(stringJson);
            return tacoRestaurant;
        }
    }
}
