using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model.Receive
{
    public class CategoryModel
    {
        public string CategoryID { get; set; }
            public string name { get; set; }
            public string remark { get; set; }
    }

    public class CategoryItemDto
    {
        public string CateId { get; set; }
        public string CateName { get; set; }
        public string remark { get; set; }

        public List<CateItemInfo> cateItemInfo { get; set; }

        public List<CateResturant> resturantInfo { get; set; }
    }

    public class CateItemInfo
    {
        public string ItemID { get; set; }
        public string SupplierID { get; set; }
        public string Name { get; set; }
    }

    public class CateResturant
    {
        public string TypeID { get; set; }
        public string name { get; set; }
    }
}
