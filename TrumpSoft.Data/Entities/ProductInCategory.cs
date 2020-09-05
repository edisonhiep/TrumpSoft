using System;
using System.Collections.Generic;
using System.Text;

namespace TrumpSoft.Data.Entities
{
    public class ProductInCategory
    {
        public int ProductId { get; set; }
        public Product product { get; set; }

        public int CategoryId { get; set; }
        public Category category { get; set; }
    }
}
