using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public int getListBillByTableId(string tableId)
        {
            try
            {
                List<Bill> listBill = new List<Bill>();
                listBill = BillDAO.Instance.getListBillByTableId(tableId);
                if (listBill != null)
                    return listBill[0].billId;
                else
                    return -1;
            }
            catch
            {
                return -1;
            }
        }
        
        public bool addBill (int customerId, string tableId)
        {
            return BillDAO.Instance.createBill(customerId, tableId);
        }


    }
}
