using System;
using System.Collections.Generic;
using System.Text;
using TrumpSoft.Data.Enums;

namespace TrumpSoft.Data.Entities
{
    public class Product
    {
        public int p_ID { get; set; }
        public string p_Name { get; set; }
        public decimal p_Price { get; set; }
        public decimal p_OriginalPrice { get; set; }
        public string p_Detail { get; set; }
        public int p_Stock { get; set; }
        public string p_SeoDescription { get; set; }
        public string p_SeoTitle { get; set; }
        public int p_ViewCount { get; set; }
        public DateTime p_DateCreated { get; set; }
        public string p_SeoAlias { get; set; }
        public Status p_Status { get; set; }

        public List<ProductInCategory> productInCategories { get; set; }
        public List<OrderDetail> orderDetails { get; set; }
        public Cart cart { get; set; }
    }
}
