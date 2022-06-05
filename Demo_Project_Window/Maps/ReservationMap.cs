using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using GUI.Models;

namespace GUI.Maps
{
    public class ReservationMap : EntityTypeConfiguration<Reservation>
    {
        public ReservationMap()
        {
            ToTable("Reservations");
            HasKey(k => new { k.customerId, k.tableId });

            Property(r => r.customerId).IsRequired();
            Property(r => r.tableId).IsRequired().IsUnicode(false);
            Property(r => r.confirmTime).IsRequired();

            HasRequired(r => r.Customer).WithMany(c => c.Reservations);
            HasRequired(r => r.Table).WithMany(t => t.Reservations);

        }
    }
}