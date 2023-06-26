using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model.Submit
{
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
    }

    public class itemSumbitModel
    {
        public string itemID {get; set; }
        public string pID { get; set; }
        public double qty { get; set; }
        public double TotalPrice { get; set; }
    }

    public class reqspoModel
    {
        public string itemID { get; set; }
    }
    public class ExpDateUpdate
    {
        public string pid { get; set; }
        public DateTime expDate { get; set; }
    }
}
