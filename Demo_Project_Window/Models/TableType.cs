using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GUI.Models
{
    public class TableType
    {
        [Key][MaxLength(5)][Required]
        public string tableTypeId { get; set; }

        [MaxLength(100)][Required]
        public string TypeName { get; set; }
        public virtual ICollection<Table> Tables { get; set; }
    }
}
