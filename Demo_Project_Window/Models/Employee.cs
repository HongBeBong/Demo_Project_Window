using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GUI.Models
{
    public class Employee
    {
        public string employeeId { get; set; }
        public string role { get; set; }
        public string fullName { get; set; }
        public string gender { get; set; }
        public DateTime birthday { get; set; }
        public int salary { get; set; }
        public virtual ICollection<Bill> Bills { get; set; }
        public virtual Account Account { get; set; }
    }
}
