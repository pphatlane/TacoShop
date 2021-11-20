using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Linq;
using System.Text;
using System.Threading.Tasks;
=======
using System.Text;
>>>>>>> a3411ca56bd11ad7c9aca07a3a00c70f6ffae2c0
using TacoShop.Domain.Interfaces.Repository;
using TacoShop.Domain.Interfaces.Service;
using TacoShop.Domain.Model;

namespace TacoShop.Logic
{
    public class BuyService : IBuyService
    {
        private readonly IBuyRepository _buyRepository;

        public BuyService(IBuyRepository buyRepository)
        {
            _buyRepository = buyRepository;
        }
<<<<<<< HEAD
        public async Task<IEnumerable<TacoRestaurant>> GetAllAvailableSortedSearchedMenu()
        {
            var searched = await _buyRepository.GetAllAvailableSearchedMenu();
            searched = searched.OrderByDescending(x=>x.Categories.Count).ThenBy(x=>x.Rank).AsEnumerable();
            return searched;
        }
    }

}


=======
        public IEnumerable<TacoRestaurant> GetAllAvailableSortedSearchedMenu()
        {
           var searched = _buyRepository.GetAllAvailableSearchedMenu();
            return searched;
        }
    }
}
>>>>>>> a3411ca56bd11ad7c9aca07a3a00c70f6ffae2c0
