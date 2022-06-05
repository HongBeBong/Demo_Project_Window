using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using GUI.Models;

namespace GUI.Maps
{
    public class TableTypeMap : EntityTypeConfiguration<TableType>
    {
        public TableTypeMap()
        {
            HasMany(t => t.Tables).WithRequired().HasForeignKey(t => t.tableTypeId);
        }
    }
}
