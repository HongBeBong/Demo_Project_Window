using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class EmployeeBUS
    {
        private static EmployeeBUS instance;

        public static EmployeeBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new EmployeeBUS();
                return EmployeeBUS.instance;
            }
            private set => instance = value;
        }

        public string createNextEmployeeId()
        {
            // lấy id dưới cùng nhất
            string lastId = EmployeeDAO.Instance.getLastEmployeeId();
            string lastestId;
            string numberPart;
            // xem số lương nhân viên đến hàng nào
            int counter = EmployeeDAO.Instance.countEmployee();
            // khi số lượng nhân viên dưới 10 người 
            if (counter <= 9)
            {
                numberPart = lastId.Substring(4);
                int tmp = Int32.Parse(numberPart);
                tmp = tmp + 1;
                if (tmp >= 10)
                {
                    lastestId = "NV0" + tmp.ToString();
                }
                else
                {
                    lastestId = "NV00" + tmp.ToString();
                }
                return lastestId;
            }
            // khi số lương nhân viên dưới 100 người 
            else if (counter <= 99)
            {
                numberPart = lastId.Substring(3);

                int tmp = Int32.Parse(numberPart);

                tmp = tmp + 1;

                if (tmp >= 100)
                    lastestId = "NV" + tmp.ToString();
                else
                    lastestId = "NV0" + tmp.ToString();
 
                return lastestId;
            }
            // khi số lượng nhân viên 100 người trở lên
            else
            {
                numberPart = lastId.Substring(2);

                int tmp = Int32.Parse(numberPart);

                tmp = tmp + 1;

                if (tmp > 999)
                    return null;
                else
                    lastestId = "NV00" + tmp.ToString();
                    return lastestId;
                
            }
                  
        }
    }
}
