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
    public class TableTypeDAO
    {
        private static TableTypeDAO instance;
        public static TableTypeDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TableTypeDAO();
                return TableTypeDAO.instance;
            }
            private set => instance = value;
        }

        //Hàm thêm 1 đối tượng TableType
        public bool createTableType(string tableTypeId, string typeName)
        {
            try
            {
                using (var con = new Context())
                {
                    TableType tableType = new TableType() { tableTypeId = tableTypeId, TypeName = typeName};
                    con.TableTypes.Add(tableType);
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

        // Hàm lấy các đối tượng TableType lên để xem 
        public List<TableType> readTableType()
        {
            try
            {
                using (Context con = new Context())
                {
                    var listTableType = con.TableTypes.ToList();
                    return listTableType;// Trả về danh sách các đội tượng TableType 
                }
            }
            catch
            {
                // Nếu có lỗi ở phần xử lí phía trên trả về false
                return null;
            }
        }


        //Hàm Update 1 đối tượng TableType
        public bool updateTableType(string tableTypeId, string typeName)
        {
            try
            {
                using (var con = new Context())
                {
                    // Lấy ra đối tượng TableType đầu tiên thỏa điều kiện trong Where
                    TableType tableType = con.TableTypes.Where(item => item.tableTypeId == tableTypeId).First();
                    // Nếu lấy ra được 1 đối tượng thỏa điều kiện thì tiến hành Update
                    if (tableType != null)
                    {
                        tableType.tableTypeId = tableTypeId;
                        tableType.TypeName = typeName;                   
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

        // Hàm xóa đi 1 đối tượng TableType
        public bool deleteTableType(string tableTypeId)
        {
            try
            {
                using (var con = new Context())
                {
                    // Lấy ra đối tượng TableType đầu tiên thỏa điều kiện trong Where
                    TableType tableType = con.TableTypes.Where(item => item.tableTypeId == tableTypeId).First();
                    // Nếu lấy ra được 1 đối tượng thỏa điều kiện thì tiến hành Delete
                    if (tableType != null)
                    {
                        con.TableTypes.Remove(tableType);
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
