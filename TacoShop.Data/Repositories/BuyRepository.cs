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
        public async Task<IEnumerable<TacoRestaurant>> GetAllAvailableSearchedMenu()
        {
            //get searched menu
            var file = "SampleData.json";
            using (var reader = File.OpenText($@"..\Files\{file}"))
            {
                var fileText = await reader.ReadToEndAsync();
                IEnumerable<TacoRestaurant> tacoRestaurant = JsonConvert.DeserializeObject<IEnumerable<TacoRestaurant>>(fileText);
                return tacoRestaurant;

            }
        }
    }
}
