using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using GUI.Models;

namespace GUI.Maps
{
    public class DishMap : EntityTypeConfiguration<Dish>
    {
        public DishMap()
        {
            HasKey(d => d.dishId);

            Property(d => d.dishId).HasMaxLength(5).IsRequired().IsUnicode(false);
            Property(d => d.dishName).HasMaxLength(255).IsRequired();
            Property(d => d.price).IsRequired();
            Property(d => d.categoryId).HasMaxLength(5).IsRequired().IsUnicode(false);
        }
    }
}
