using AutoMapper;
using Server.Model.Entity;

namespace Server.Model.Dto
{
    public class PuchaseMap : Profile
    {
        public PuchaseMap()
        {

        }
    }

    public class GetPurItemDto
    {
        public string ItemID { get; set; }
        public string ItemName { get; set; }
        public int itemQty { get; set; }
    }


    public class BpaListDto
    {
        public int ID { get; set; }
        public string refsupNum {get;set;}
        public List<BpaItemListDto> items { get; set; }
    }
    public class BpaItemListDto
    {
        public string ItemID { get; set; }
        public string ItemName { get; set; }
        public string unit { get; set; }
        public double price { get; set; }
        public double MOQ { get; set; }
        public string refSupID {get;set;}
    }
}
