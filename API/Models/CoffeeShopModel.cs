using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class CoffeeShopModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string OpenHours { get; set; }
        public string Address { get; set; }
    }
}