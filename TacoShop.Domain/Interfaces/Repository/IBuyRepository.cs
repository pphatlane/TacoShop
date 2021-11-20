using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TacoShop.Domain.Model;

namespace TacoShop.Domain.Interfaces.Repository
{
    public interface IBuyRepository
    {
        Task<IEnumerable<TacoRestaurant>> GetAllAvailableSearchedMenu();
    }
}
