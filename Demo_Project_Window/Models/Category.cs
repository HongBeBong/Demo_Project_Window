using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GUI.Models
{
    public class Category
    {
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Dish> Dishes { get; set; }

    }
}
