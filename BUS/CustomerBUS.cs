using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using GUI.Models;

namespace BUS
{
    public class CustomerBUS
    {

        private static CustomerBUS instance;

        public static CustomerBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new CustomerBUS();
                return CustomerBUS.instance;
            }
            private set => instance = value;
        }


        public int addCustomer(string name, string phone, string address, string gender)
        {
            bool check = CustomerDAO.Instance.createCustomer(name, phone, address, gender);
            if (check == true)
            {
                
                int a = CustomerDAO.Instance.getLatestCustomer();
                Console.WriteLine("id cua khach hang vua tao la {0}", a);
                return a;
            }     
            return -1;
        }


    }
}
