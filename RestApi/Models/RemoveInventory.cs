using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestApi.Models
{
    public class RemoveInventory
    {
        public int CableQuantity { get; set; }
        public int ConnecterQuantity { get; set; }
        public int HeatShrinkQuantity { get; set; }
    }
}