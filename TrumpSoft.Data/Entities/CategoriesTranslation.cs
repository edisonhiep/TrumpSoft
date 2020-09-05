using System;
using System.Collections.Generic;
using System.Text;

namespace TrumpSoft.Data.Entities
{
    public class CategoriesTranslation
    {
        public int ct_ID { get; set; }
        public int ct_CategoryID { get; set; }
        public string ct_Name { get; set; }
        public string ct_SeoDescription { get; set; }
        public string ct_SeoTitle { get; set; }
        public string ct_SeoAlias { get; set; }
        public int ct_LanguageID { get; set; }

        public List<Language> languages { get; set; }
        public List<Category> categories { get; set; }

    }
}
