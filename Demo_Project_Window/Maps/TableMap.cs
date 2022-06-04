using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using GUI.Models;

namespace GUI.Maps
{
    public class TableMap : EntityTypeConfiguration<Table>
    {
        public TableMap()
        {
            Property(t => t.tableId).IsUnicode(false);
            Property(t => t.tableTypeId).IsUnicode(false);
            Property(t => t.status).IsUnicode(false).HasMaxLength(15).IsRequired();

            HasMany(t => t.Bills).WithRequired().HasForeignKey(t => t.tableId);
        }
    }
}
