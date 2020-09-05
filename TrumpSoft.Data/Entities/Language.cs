using System;
using System.Collections.Generic;
using System.Text;
using TrumpSoft.Data.Enums;

namespace TrumpSoft.Data.Entities
{
    public class Language
    {
        public int l_ID { get; set; }
        public string l_Name { get; set; }
        public Defaults l_IsDefault { get; set; }
    }
}
