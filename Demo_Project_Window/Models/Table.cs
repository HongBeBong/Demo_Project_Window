using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GUI.Models
{
    public class Table
    {
        [Key][MaxLength(5)][Required]
        public string tableId { get; set; }

        [MaxLength(5)]
        [Required]
        public string tableTypeId { get; set; }
        public string status { get; set; }

        public virtual ICollection<Bill> Bills { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }

    }
}
