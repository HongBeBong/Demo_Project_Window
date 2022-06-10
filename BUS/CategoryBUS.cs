using GUI.Models;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CategoryBUS
    {
        private static CategoryBUS instance;

        public static CategoryBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new CategoryBUS();
                return CategoryBUS.instance;
            }
            private set => instance = value;
        }

        public List<Category> getListCategory()
        {
            List<Category> listCategory = new List<Category>();
            listCategory = CategoryDAO.Instance.getListCategory();
            return listCategory;
        }
    }
}
