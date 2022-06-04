using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using GUI.Models;

namespace GUI.Maps
{
    public class BillMap : EntityTypeConfiguration<Bill>
    {
        public BillMap()
        {
            HasKey(b => b.billId);
            Property(b => b.billId).IsRequired();

            HasMany(b => b.Dishes)
                .WithMany(d => d.Bills)
                .Map(
                    m => {
                        m.MapLeftKey("billId");
                        m.MapRightKey("dishId"); 
                    }
                 );
        }
    }
}
