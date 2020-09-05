using System;
using System.Collections.Generic;
using System.Text;
using TrumpSoft.Data.Enums;

namespace TrumpSoft.Data.Entities
{
    public class Transation
    {
        public int t_ID { get; set; }
        public DateTime t_TransactionDate { get; set; }
        public int t_ExternalTransactionID { get; set; }
        public decimal t_Amount { get; set; }
        public decimal t_Fee { get; set; }
        public string t_Result { get; set; }
        public string t_Message { get; set; }
        public TransationStatus t_Status { get; set; }
        public string t_Provider { get; set; }
    }
}
