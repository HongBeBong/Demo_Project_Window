using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using GUI.Models;

namespace GUI
{
    public class Initializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            base.Seed(context);
            var employee = new Employee
            {
                employeeId = "EMP1",
                fullName = "Bùi Thanh Duy",
                role = "Nhân Viên",
                birthday = "30-4-2002",
                gender = "Nam",
                salary = 30000000
            };
            context.Employees.Add(employee);
            context.SaveChanges();
        }
    }
}
