using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public async Task<IEnumerable<TacoRestaurant>> GetAllAvailableSortedSearchedMenu()
        {
            var searched = await _buyRepository.GetAllAvailableSearchedMenu();
            searched = searched.OrderByDescending(x=>x.Categories.Count).ThenBy(x=>x.Rank).AsEnumerable();
            return searched;
        }
    }

}
