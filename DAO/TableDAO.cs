using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI;
using GUI.Maps;
using GUI.Models;

namespace DAO
{
    public class TableDAO
    {
        private static TableDAO instance;
        public static TableDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TableDAO();
                return TableDAO.instance;
            }
            private set => instance = value;
        }

        //Hàm thêm 1 đối tượng Table
        public bool createTable(string tableID, string tableTypeId, string status)
        {
            try
            {
                using (var con = new Context())
                {
                    Table table = new Table() {tableId = tableID, tableTypeId = tableTypeId, status = status};
                    con.Tables.Add(table);
                    con.SaveChanges();
                    return true;// Nếu thêm thành công trả về true
                }
            }
            catch
            {
                // Nếu có lỗi ở phần xử lí phía trên trả về false
                return false;
            }
        }

        // Hàm lấy các đối tượng Table lên để xem 
        public List<Table> readTable()
        {
            try
            {
                using (Context con = new Context())
                {
                    var listTable = con.Tables.ToList();
                    return listTable;// Trả về danh sách các đội tượng Table 
                }
            }
            catch
            {
                // Nếu có lỗi ở phần xử lí phía trên trả về false
                return null;
            }
        }

        //Hàm Update 1 đối tượng Table
        public bool updateTable(string tableID, string tableTypeId, string status)
        {
            try
            {
                using (var con = new Context())
                {
                    // Lấy ra đối tượng Table đầu tiên thỏa điều kiện trong Where
                    Table table = con.Tables.Where(item => item.tableId == tableID).First();
                    // Nếu lấy ra được 1 đối tượng thỏa điều kiện thì tiến hành Update
                    if (table != null)
                    {
                        table.tableId = tableID;
                        table.tableTypeId = tableTypeId;
                        table.status = status;
                        con.SaveChanges();
                        return true;
                    }
                    //Ngược lại thì trả về true
                    else
                    {
                        return false;
                    }
                }
            }
            catch
            {
                // Nếu có lỗi ở phần xử lí phía trên trả về false
                return false;
            }
        }

        // Hàm xóa đi 1 đối tượng Table
        public bool deleteTable(string tableID)
        {
            try
            {
                using (var con = new Context())
                {
                    // Lấy ra đối tượng Table đầu tiên thỏa điều kiện trong Where
                    Table table = con.Tables.Where(item => item.tableId == tableID).First();
                    // Nếu lấy ra được 1 đối tượng thỏa điều kiện thì tiến hành Delete
                    if (table != null)
                    {
                        con.Tables.Remove(table);
                        con.SaveChanges();
                        return true;
                    }
                    // Ngược lại thì trả về true
                    else
                    {
                        return false;
                    }
                }
            }
            catch
            {
                // Nếu có lỗi ở phần xử lí phía trên trả về false
                return false;
            }
        }

        public bool switchTable(string tableId1, string tableId2, int billId1, int billId2)
        {
            try
            {
                using (var context = new Context())
                {
                    if (billId1 != -1 && billId2 != -1)
                    {
                        BillDAO.Instance.updateBill(tableId1, billId2);
                        BillDAO.Instance.updateBill(tableId2, billId1);
                        return true;
                    }
                    else if (billId1 != -1 && billId2 == -1)
                    {
                        BillDAO.Instance.updateBill(tableId2, billId1);
                        updateSatusAndColor(tableId1, "ON");
                        updateSatusAndColor(tableId2, "OFF");
                        return true;
                    }
                    else if (billId1 == -1 && billId2 != -1)
                    {
                        BillDAO.Instance.updateBill(tableId1, billId2);
                        updateSatusAndColor(tableId1, "OFF");
                        updateSatusAndColor(tableId2, "ON");
                        return true;
                    }
                    else if (billId1 == -1 && billId2 == -1)
                    {
                        return true;
                    }
                    else
                        return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool updateSatusAndColor(string tableId, string status)
        {
            try
            {
                using (var context = new Context())
                {
                    var table = context.Tables.Where(item => item.tableId == tableId).FirstOrDefault();
                    table.status = status;
                    context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
