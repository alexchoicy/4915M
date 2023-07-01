using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model.Submit
{
    public class OrderSubmitModel
    {
        public string OrderId { get; set; }
        public string RestaurantID { get; set; }
        public DateTime date { get; set; }
        public TimeSpan time { get; set; }
        public bool emergency { get; set; }
        public string remark { get; set; }
        public List<OrderItemModel> OrderItems { get; set; }
    }


    public class OrderItemModel
    {
        public string ItemID { get; set; }
        public double Quantity { get; set; }
    }



}
