namespace Server.Controllers.Input
{
    public class ContactModel
    {
        public string ContractID { get; set; }
        public DateTime SignDate { get; set; }
        public string supplierID { get; set; }
        public string staffID { get; set; }
        public List<ItemModel>? Items { get; set; }
    }
}
