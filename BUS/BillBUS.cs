using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using GUI.Models;

namespace BUS
{
    public class BillBUS
    {
        private static BillBUS instance;

        public static BillBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillBUS();
                return BillBUS.instance;
            }
            private set => instance = value;
        }

        public int getBillIDByTableId(string tableId)
        {
            try
            {
                List<Bill> listBill = new List<Bill>();
                listBill = BillDAO.Instance.getBillIDByTableId(tableId);
                if (listBill != null)
                    return listBill[0].billId;
                else
                    return -1;// Nếu tìm kiếm billdId theo tableId không có trong bảng Bills
            }
            catch
            {
                return -1;// Hoặc xảy ra lỗi.
            }
        }
        
        public bool addBill (int customerId, string tableId)
        {
            return BillDAO.Instance.createBill(customerId, tableId);
        }

        public int getBillId(int customerId, string tableId)
        {
            return BillDAO.Instance.getBillId(customerId, tableId);
        }


        public void loadInfoBill(DataGridView dgv, int billId)
        {
            BillDAO.Instance.getDataGridViewInfomation(dgv, billId);
        }

        public bool updateEmployeeAndTime(int id, string employeeId, int totalprice)
        {
            return BillDAO.Instance.updateEmployeeAndTime(id, employeeId, totalprice);
        }

        public Bill getBillById (int id)
        {
            return BillDAO.Instance.getBillById(id);
        }

        public int getCustomerId (string tableId, int totalprice)
        {
            return BillDAO.Instance.getCustomerIdByTableIdAndToTal(tableId, totalprice);
        }
    }
}
