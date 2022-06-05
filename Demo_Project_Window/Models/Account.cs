using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GUI.Models
{
    public class Account
    {
        public string accountEmployeeId { get; set; }
        public string accountType { get; set; }
        public string userName { get; set; }
        public string displayName { get; set; }
        public string password { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
