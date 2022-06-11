using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI;
using GUI.Models;


namespace DAO
{
    public class EmployeeDAO
    {
        private static EmployeeDAO instance;

        public static EmployeeDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new EmployeeDAO();
                return EmployeeDAO.instance;
            }
            private set => instance = value;
        }

        // methods

        // get all employee
        public List<Employee> getAllEmmployees()
        {
            try
            {
                using (var context = new Context())
                {
                    var listEmployees = context.Employees;
                    return listEmployees.ToList();
                }
            }
            catch
            {
                Console.WriteLine("Get All Employee Failed");
                return null;
            }
        }
        

        public bool createAnEmployee(string employeeId, string role, string fullname, string gender, DateTime birthday, int salary)
        {
            try
            {
                
                using (var context = new Context())
                {
                    // tạo một đối tượng employee mới
                    var employee = new Employee()
                    {
                        employeeId = employeeId,
                        role = role,
                        fullName = fullname,
                        gender = gender,
                        birthday = birthday,
                        salary = salary
                    };
                    // thêm và cập nhật thay đổi
                    context.Employees.Add(employee);
                    context.SaveChanges();
                }

                return true; // thành công

            }
            catch
            {
                return false; // Thêm record thất bại
            }
        }


        public bool deleteAnEmployee (string employeeId)
        {
            try
            {
                using (var context = new Context())
                {
                    // lấy employee theo id
                    var delectedEmployee = context.Employees.SingleOrDefault(e => e.employeeId == employeeId);
                    // xóa ra khỏi list employees
                    context.Employees.Remove(delectedEmployee);
                    // xác nhận thay đổi
                    context.SaveChanges();
                    return true; // xóa thành công
                }
            }
            catch
            {
                return false; //xóa thất bại
            }
        }


        public string getLastEmployeeId()
        {
            try
            {
                using (var context = new Context())
                {
                    var employees = context.Employees.ToList();
                    Employee emp1 = employees.LastOrDefault();
                    return emp1.employeeId;
                }
            }
            catch
            {
                return null;
            }
        }

        public int countEmployee()
        {
            try
            {
                using (var context = new Context())
                {
                    int value = context.Employees.Count();
                    return value;
                }
            }
            catch
            {
                return -1;
            }
        }

    }


}
