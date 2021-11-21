using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TacoShop.Domain.Model;

namespace TacoShop.Domain.Interfaces.Service
{
    public interface IBuyService
    {
        Task<IEnumerable<TacoRestaurant>> GetAllAvailableSortedSearchedMenu(string searchString);
    }
}
