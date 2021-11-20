using System;
using System.Collections.Generic;
using System.Text;

namespace TacoShop.Domain.Model
{
    public class Categories
    {
        public string Name { get; set; }
        public List<MenuItems> MenuItems { get; set; }
    }
}
