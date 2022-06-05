using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI.Models;
using GUI;

namespace DAO
{
    public class CustomerDAO
    {
        private static CustomerDAO instance;

        public static CustomerDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CustomerDAO();
                return CustomerDAO.instance;
            }
            private set => instance = value;
        }


        // methods enteract with data
        public Customer getCustomerById (int customerId)
        {
            try
            {
                using (var context = new Context())
                {
                    var customer = context.Customers.SingleOrDefault(c => c.customerId == customerId);
                    return customer; 
                    // lấy thông tin khách hàng thành công
                }
            }
            catch
            {
                return null; // lấy thông tin khách hàng thất bại
            }
        }

        public bool createCustomer (string fullName, string phoneNumber, string address, string gender)
        {
            try
            {
                // tạo customer mới 
                var customer = new Customer()
                {
                    fullName = fullName,
                    phoneNumber = phoneNumber,
                    address = address,
                    gender = gender,
                };
                // thêm và lưu thay đổi
                using (var context = new Context())
                {
                    context.Customers.Add(customer);
                    context.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteCustomer (int id)
        {
            try
            {
                using (var context = new Context())
                {
                    var customer = context.Customers.Find(id);
                    context.Customers.Remove(customer);

                    context.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
