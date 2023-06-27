using Microsoft.AspNetCore.Mvc;
using Server.Helper;

namespace Server.Controllers.Input
{
    public class PuchaseNewModel
    {
        [ModelBinder(BinderType = typeof(FormDataJsonBinder))]
        public PurchaseSumbitModel PurchaseData { get; set; }
        public IFormFileCollection files { get; set; }

    }
    public class PurchaseSumbitModel
    {
        public SumbitDataModel data { get; set; }
        public List<itemSumbitModel> item { get; set; }
    }


    public class SumbitDataModel
    {
        public string pid { get; set; }
        public string Type { get; set; }
        public string refAggreNum { get; set; }
        public string supID { get; set; }
        public DateTime date { get; set; } = DateTime.Now;
        public string DN { get; set; }
    }

    public class itemSumbitModel
    {
        public string itemID { get; set; }
        public string pID { get; set; }
        public double qty { get; set; }
        public double TotalPrice { get; set; }
    }

    public class reqspoModel
    {
        public string itemID { get; set; }
    }
}
