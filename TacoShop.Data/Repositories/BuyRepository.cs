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
<<<<<<< HEAD
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
=======
        public IEnumerable<TacoRestaurant> GetAllAvailableSearchedMenu()
        {
            //get searched menu
            var file = "SampleData.json";
            var stringJson = File.ReadAllText($@"..\..\Files\{file}");
            IEnumerable<TacoRestaurant> tacoRestaurant = JsonConvert.DeserializeObject<IEnumerable<TacoRestaurant>>(stringJson);
            return tacoRestaurant;
>>>>>>> a3411ca56bd11ad7c9aca07a3a00c70f6ffae2c0
        }
    }
}
