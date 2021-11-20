﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TacoShop.Domain.Interfaces.Service;
using TacoShop.Domain.Model;

namespace FrontShop.Web.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TacoShopController : ControllerBase
    {
        private readonly IBuyService _buyService;
       public TacoShopController(IBuyService buyService)
        {
            _buyService = buyService;
        }

        [HttpGet("SearchForMenu")]
        public async Task<ActionResult<IEnumerable<TacoRestaurant>>> SearchForMenu()
        {
            var tacoMenu = await _buyService.GetAllAvailableSortedSearchedMenu();
            return Ok(tacoMenu);
        }

    }
}
