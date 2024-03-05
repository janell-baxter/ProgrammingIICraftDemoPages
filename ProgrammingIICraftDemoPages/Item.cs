using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingIICraftDemoPages
{
    public class Item
    {
        public string ItemName = "";
        public string ItemDescription = "";
        public double ItemValue = 0;
        public double ItemAmount = 1;
        public string ItemAmountType = "cup(s)";

        public string GetItemDescription()
        {
            return $"{ItemAmount} {ItemAmountType} {ItemName} ({ItemValue.ToString("C")} ea)\n{ItemDescription}";
        }
    }
}
