using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI.Models;
using DAO;

namespace BUS
{
    public class TableTypeBUS
    {
        private static TableTypeBUS instance;

        public static TableTypeBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new TableTypeBUS();
                return TableTypeBUS.instance;
            }
            private set => instance = value;
        }

        public List<TableType> getAllTableTypes()
        {
            return TableTypeDAO.Instance.readTableType();
        }
    }



}
