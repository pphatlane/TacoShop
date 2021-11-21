using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        public async Task<IEnumerable<TacoRestaurant>> GetAllAvailableSortedSearchedMenu(string searchString)
        {
            //i know this is bad, for the sake of returning results
            var category = searchString.Split(new string[] { "in" }, StringSplitOptions.None)[0].Trim();
            var city = searchString.Split(new string[] { "in" }, StringSplitOptions.None)[1].Trim();
            var searched = await _buyRepository.GetAllAvailableSearchedMenu();
            var suggestions = searched.Where(x => x.City == city);
            suggestions = suggestions
                            .Where(a =>
                            a.Categories
                            .Select(arrayElement => arrayElement)
                            .Any(value => value.Name.Contains(category)));

            searched = suggestions.OrderByDescending(x=>x.Categories.Count).ThenByDescending(x=>x.Rank).AsEnumerable();
            return searched;
        }
    }

}
