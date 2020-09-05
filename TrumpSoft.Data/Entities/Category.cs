using System;
using System.Collections.Generic;
using System.Text;
using TrumpSoft.Data.Enums;

namespace TrumpSoft.Data.Entities
{
    public class Category
    {
        public int c_ID { get; set; }
        public string c_Name { get; set; }
        public int c_SortOrder { get; set; }
        public bool c_IsShowOnHome { get; set; }
        public int? c_ParentID { get; set; }
        public Status c_Status { get; set; }
        public string c_SeoDescription { get; set; }
        public string c_SeoTitle { get; set; }

        public List<ProductInCategory> productInCategories { get; set; }
    }
}
