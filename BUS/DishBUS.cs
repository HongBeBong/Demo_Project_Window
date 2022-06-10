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
    }
}
