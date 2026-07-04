using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Entity
{
    internal class SalesRecord
    {
        public DateTime SaleDate { get; set; }
        public string StoreCode { get; set; } = "";
        public string ProductCode { get; set; } = "";
        public string ProductName { get; set; } = "";
        public string Category { get; set; } = "";
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
