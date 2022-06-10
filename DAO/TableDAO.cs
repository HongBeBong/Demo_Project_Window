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
        public bool updateTable(string tableID, string status)
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
    }
}
