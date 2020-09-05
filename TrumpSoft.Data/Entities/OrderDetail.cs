using System;
using System.Collections.Generic;
using System.Text;

namespace TrumpSoft.Data.Entities
{
    public class OrderDetail
    {
        public int od_ProductID{get;set;}
        public decimal od_Quantity{get;set;}
        public decimal od_Price{get;set;}
        public int od_OrderID{get;set;}
        public Order order { get; set; }
        public Product product { get; set; }
    }
}
