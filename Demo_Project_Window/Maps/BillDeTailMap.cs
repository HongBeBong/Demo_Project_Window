using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using GUI.Models;

namespace GUI.Maps
{
    public class BillDeTailMap : EntityTypeConfiguration<BillDetail>
    {
        public BillDeTailMap()
        {
            ToTable("BillDeTail");
            HasKey(k => new { k.billId, k.dishId });

            //Property(x => x.billId).HasMaxLength(5).IsRequired().IsUnicode(false);
            Property(x => x.billId).IsRequired();
            Property(x => x.dishId).HasMaxLength(5).IsRequired().IsUnicode(false);
            Property(x => x.quatity).IsRequired();

            HasRequired(dt => dt.Bill).WithMany(b => b.BillDetails);
            HasRequired(dt => dt.Dish).WithMany(d => d.BillDetails);

        }
    }
}