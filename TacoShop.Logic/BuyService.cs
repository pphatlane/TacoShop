using System;
using System.Collections.Generic;
using System.Text;
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
        public IEnumerable<TacoRestaurant> GetAllAvailableSortedSearchedMenu()
        {
           var searched = _buyRepository.GetAllAvailableSearchedMenu();
            return searched;
        }
    }
}
