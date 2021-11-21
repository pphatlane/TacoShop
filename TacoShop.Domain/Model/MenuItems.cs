using System;
using System.Collections.Generic;
using System.Text;

namespace TacoShop.Domain.Model
{
    public class MenuItems
    {
        public bool Checked { get; set; }
        public int Id { get; set; }
        public string name { get; set; }
        public decimal Price { get; set; }
    }
}
