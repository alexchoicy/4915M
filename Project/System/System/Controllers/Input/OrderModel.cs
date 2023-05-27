namespace Server.Controllers.Input
{
    public class OrderModel
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
        public int Quantity { get; set; }
    }
}
