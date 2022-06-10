using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace BUS
{
    public class BillDetailBUS
    {
        private static BillDetailBUS instance;

        public static BillDetailBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillDetailBUS();
                return BillDetailBUS.instance;
            }
            private set => instance = value;
        }

        //===========================================Method=============================================================
        public void createBillDetail(int billId, string dishId, int quantity)
        {
            if (BillDetailDAO.Instance.createBillDetail(billId, dishId, quantity))
            {
                MessageBox.Show("Add BillDetail access", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Add BillDetail fail", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void updateBillDetail(int billId, string dishId, int quantity)
        {
            if (BillDetailDAO.Instance.updateBillDetail(billId, dishId, quantity) == false)
            {
                MessageBox.Show("Add BillDetail fail", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
