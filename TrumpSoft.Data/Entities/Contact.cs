using System;
using System.Collections.Generic;
using System.Text;
using TrumpSoft.Data.Enums;

namespace TrumpSoft.Data.Entities
{
    public class Contact
    {
        public int c_ID { get; set; }
        public string c_Name { get; set; }
        public string c_Email { get; set; }
        public string c_PhoneNumber { get; set; }
        public string c_Message { get; set; }
        public Status c_Status { get; set; }
    }
}
