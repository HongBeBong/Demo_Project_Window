using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GUI.Models
{
    public class Bill
    {
        public int billId { get; set; }
        public int customerId { get; set; }
        public string tableId { get; set; }
        public string employeeId { get; set; }
        public DateTime createAt { get; set; }
        public int totalPrice { get; set; }

        public virtual ICollection<Dish> Dishes { get; set; }
        public virtual ICollection<BillDetail> BillDetails { get; set; }



    }
}
