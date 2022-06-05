using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using GUI.Models;


namespace GUI.Maps
{
    public class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {

            HasKey(e => e.employeeId);
            HasOptional(a => a.Account).WithRequired(e => e.Employee).WillCascadeOnDelete(true);

            Property(e => e.employeeId).HasMaxLength(5).IsUnicode(false);
            Property(e => e.fullName).IsRequired().HasMaxLength(100);
            Property(e => e.role).IsOptional();
            Property(e => e.gender).IsRequired().HasMaxLength(5);
            Property(e => e.birthday).HasMaxLength(15).IsRequired().IsUnicode(false);
            Property(e => e.salary).IsRequired();

            HasMany(e => e.Bills).WithOptional().HasForeignKey(e => e.employeeId);
            
        }
    }
}
