using GUI.Models;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class DishBUS
    {
        private static DishBUS instance;

        public static DishBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new DishBUS();
                return DishBUS.instance;
            }
            private set => instance = value;
        }

        public List<Dish> getListFoodByCategoryId(string categoryId)
        {
            List<Dish> listDish = new List<Dish>();
            listDish = DishDAO.Instance.getListFoodByCategoryId(categoryId);
            return listDish;
        }

        public void showInfoOrder(DataGridView dtv, string tableId)
        {
            DishDAO.Instance.showInfoOrder(dtv, tableId);
        }


        // những hàm này dùng để xử lý form add
        public string createNextDishId()
        {
            // lấy id dưới cùng nhất
            string lastId = DishDAO.Instance.getLastDishId();
            string lastestId;
            string numberPart;

            // xem số lương nhân viên đến hàng nào
            int counter = EmployeeDAO.Instance.countEmployee();

            // khi số lượng món viên dưới 10  
            if (counter <= 9)
            {
                numberPart = lastId.Substring(3);
                int tmp = Int32.Parse(numberPart);
                tmp = tmp + 1;
                if (tmp >= 10)
                {
                    lastestId = "T0" + tmp.ToString();
                }
                else
                {
                    lastestId = "T00" + tmp.ToString();
                }
                return lastestId;
            }
            // khi số lương món dưới 100 
            else if (counter <= 99)
            {
                numberPart = lastId.Substring(2);

                int tmp = Int32.Parse(numberPart);

                tmp = tmp + 1;

                if (tmp >= 100)
                    lastestId = "T" + tmp.ToString();
                else
                    lastestId = "T0" + tmp.ToString();

                return lastestId;
            }
            // khi số lượng nhân viên 100 người trở lên
            else
            {
                numberPart = lastId.Substring(1);

                int tmp = Int32.Parse(numberPart);

                tmp = tmp + 1;

                if (tmp > 999)
                    return null;
                else
                {
                    lastestId = "T" + tmp.ToString();
                    return lastestId;
                }

            }

        }

        public bool addNewDish(string id, string name, int price, string categoryId)
        {
            return DishDAO.Instance.createDish(id, name, price, categoryId);
        }
    }
}
