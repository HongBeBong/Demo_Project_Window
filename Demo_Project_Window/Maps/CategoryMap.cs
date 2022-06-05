using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using GUI.Models;

namespace GUI.Maps
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            HasKey(k => k.CategoryId);

            Property(c => c.CategoryId).HasMaxLength(5).IsRequired().IsUnicode(false);
            Property(c => c.CategoryName).HasMaxLength(255).IsRequired();

            HasMany(c => c.Dishes).WithRequired().HasForeignKey(d => d.categoryId);
        }
    }
}
