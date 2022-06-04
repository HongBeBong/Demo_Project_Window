using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GUI.Models
{
    public class Dish
    {
        public string dishId { get; set; }
        public string dishName { get; set; }
        public int price { get; set; }
        public string categoryId { get; set; }
        public virtual ICollection<Bill> Bills { get; set; }
        public virtual ICollection<BillDetail> BillDetails { get; set; }

    }
}
