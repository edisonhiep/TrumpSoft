using System;
using System.Collections.Generic;
using System.Text;

namespace TrumpSoft.Data.Entities
{
    public class ProductTranslation
    {
        public int pt_ID { get; set; }
        public int pt_ProductID { get; set; }
        public string pt_Name { get; set; }
        public string pt_Description { get; set; }
        public string pt_Detail { get; set; }
        public string pt_SeoDescription { get; set; }
        public string pt_SeoTitle { get; set; }
        public string pt_SeoAlias { get; set; }
        public int pt_LanguageID { get; set; }
        public List<Product> products { get; set; }
        public List<Language> languages { get; set; }
    }
}
