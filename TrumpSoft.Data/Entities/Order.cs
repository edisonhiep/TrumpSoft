using System;
using System.Collections.Generic;
using System.Text;
using TrumpSoft.Data.Enums;

namespace TrumpSoft.Data.Entities
{
    public class Order
    {
        public int o_ID { get; set; }
        public DateTime o_OrderDate { get; set; }
        public int o_UserID { get; set; }
        public string o_ShipName { get; set; }
        public string o_ShipAdress { get; set; }
        public string o_ShipEmail { get; set; }
        public string o_ShipPhoneNumber { get; set; }
        public OrderStatus o_Status { get; set; }
        public List<OrderDetail> orderDetails { get; set; }
    }
}
