using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI.Models;
using GUI.Maps;

namespace GUI
{
    public class Context : DbContext
    {
        public Context() : base("name=RestaurantDB")
        {
            
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet <TableType> TableTypes { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<BillDetail> BillDetails { get; set; }
        public DbSet<Reservation> Reservations { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new AccountMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new DishMap());
            modelBuilder.Configurations.Add(new TableTypeMap());
            modelBuilder.Configurations.Add(new TableMap());
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new BillMap());
            modelBuilder.Configurations.Add(new BillDeTailMap());
            modelBuilder.Configurations.Add(new ReservationMap());
        }
    }
}
