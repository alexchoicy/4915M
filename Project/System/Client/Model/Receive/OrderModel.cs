using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model.Receive
{
    public class OrderModel
    {
        public string OrderID { get; set; }
        public string status { get; set; }
        public DateTime CreatedDate { get; set; }
        public TimeSpan CreateTime { get; set; }
        public bool emergency { get; set; }
        public bool MapLocked { get; set; }
    }

    public class OrderModelWithItems
    {
        public string OrderID { get; set; }
        public string status { get; set; }
        public DateTime CreatedDate { get; set; }
        public TimeSpan CreateTime { get; set; }
        public bool emergency { get; set; }
        public string remark { get; set; }
        public List<OrderModelWithItemsData> OrderItems { get; set; }
    }
    public class OrderModelWithItemsData
    {
        public string ItemID { get; set; }
        public string Name { get; set; }
        public double Quantity { get; set; }
    }
}
