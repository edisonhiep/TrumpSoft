using System;
using System.Collections.Generic;
using System.Text;

namespace TrumpSoft.Data.Entities
{
    public class Cart
    {
        public int c_ID { get; set; }
        public int c_ProductID { get; set; }
        public decimal c_Quantity { get; set; }
        public decimal c_Price { get; set; }
        public List<Product> products { get; set; }
    }
}
