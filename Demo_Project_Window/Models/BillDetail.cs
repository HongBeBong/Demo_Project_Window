using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Models
{
    public class BillDetail
    {
        public int billId { get; set; }
        public string dishId { get; set; }
        public int quatity { get; set; }

        public virtual Bill Bill { get; set; }
        public virtual Dish Dish { get; set; }

    }
}
