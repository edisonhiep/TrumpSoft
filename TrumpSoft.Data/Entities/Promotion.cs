using System;
using System.Collections.Generic;
using System.Text;
using TrumpSoft.Data.Enums;

namespace TrumpSoft.Data.Entities
{
    public class Promotion
    {
        public int p_ID { get; set; }
        public string p_Name { get; set; }
        public DateTime p_FromDate { get; set; }
        public DateTime p_ToDate { get; set; }
        public ApplyPromotion p_ApplyForAll { get; set; }
        public int p_DiscountPercent { get; set; }
        public int p_DiscountAmount { get; set; }
        public int p_ProductID { get; set; }
        public int p_CategoryID { get; set; }
        public Status p_Status { get; set; }
        public List<Category> Categories { get; set;}
        public List<Product> products { get; set; }
    }
}
