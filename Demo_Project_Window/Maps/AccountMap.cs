using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using GUI.Models;

namespace GUI.Maps
{
    public class AccountMap : EntityTypeConfiguration<Account>
    {
        public AccountMap()
        {
            HasKey(k => k.accountEmployeeId);

            Property(a => a.accountEmployeeId).IsRequired();
            Property(a => a.accountType).HasMaxLength(10).IsRequired();
            Property(a => a.displayName).HasMaxLength(50).IsRequired();
            Property(a => a.password).HasMaxLength(255).IsRequired().IsUnicode(false);
        }
    }
}
