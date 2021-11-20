using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TacoShop.Domain.Model;

namespace TacoShop.Domain.Interfaces.Repository
{
    public interface IBuyRepository
    {
<<<<<<< HEAD
        Task<IEnumerable<TacoRestaurant>> GetAllAvailableSearchedMenu();
=======
        IEnumerable<TacoRestaurant> GetAllAvailableSearchedMenu();
>>>>>>> a3411ca56bd11ad7c9aca07a3a00c70f6ffae2c0
    }
}
