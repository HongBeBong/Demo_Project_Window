using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using GUI.Models;

namespace GUI.Maps
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            HasKey(k => k.customerId);

            Property(c => c.fullName).IsRequired().HasMaxLength(100);
            Property(c => c.address).IsRequired().HasMaxLength(500);
            Property(c => c.gender).IsRequired().HasMaxLength(10);
            Property(c => c.phoneNumber).IsRequired().HasMaxLength(15);

            HasMany(c => c.Bills).WithRequired().HasForeignKey(c => c.customerId);

            HasMany(c => c.Tables).WithMany(t => t.Customers)
                .Map(m =>
                {
                    m.MapLeftKey("customerId");
                    m.MapRightKey("tableId");
                });
        }
    }
}
