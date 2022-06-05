using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Models
{
    public class Reservation
    {
        public int customerId { get; set; }
        public string tableId { get; set; }
        public DateTime confirmTime { get; set; }

        public virtual Table Table { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
