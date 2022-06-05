using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GUI.Models
{
    public class Customer
    {
        public int customerId { get; set; }
        public string fullName { get; set; }
        public string phoneNumber { get; set; }
        public string address { get; set; }
        public string gender { get; set; }

        public virtual ICollection<Bill> Bills { get; set; }
        public virtual ICollection<Table> Tables { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
