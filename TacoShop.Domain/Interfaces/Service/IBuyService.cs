using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TacoShop.Domain.Model;

namespace TacoShop.Domain.Interfaces.Service
{
    public interface IBuyService
    {
<<<<<<< HEAD
        Task<IEnumerable<TacoRestaurant>> GetAllAvailableSortedSearchedMenu();
=======
        IEnumerable<TacoRestaurant> GetAllAvailableSortedSearchedMenu();
>>>>>>> a3411ca56bd11ad7c9aca07a3a00c70f6ffae2c0
    }
}
