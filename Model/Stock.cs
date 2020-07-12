using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stoack_List.Model
{
    public class Stock
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StockPurchased { get; set; }
        public DateTime? StockSold { get; set; }
    }
}
