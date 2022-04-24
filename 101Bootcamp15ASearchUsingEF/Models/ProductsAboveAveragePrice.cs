using System;
using System.Collections.Generic;

namespace _101Bootcamp15ASearchUsingEF.Models
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
