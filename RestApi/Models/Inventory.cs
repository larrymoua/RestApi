using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestApi.Models
{
    public class Inventory
    {
     
        public string ItemName { get; set; }
        public int ?Quantity { get; set; }
        public string ItemPartNumber { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public string OrderStatus { get; set; }

    }
}