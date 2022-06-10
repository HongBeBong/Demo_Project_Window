using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using GUI.Models;

namespace BUS
{
    public class TableBUS
    {
        private static TableBUS instance;

        public static TableBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new TableBUS();
                return TableBUS.instance;
            }
            private set => instance = value;
        }


        public string getAvailableTableId(string tableTypeId)
        {
            try
            {
                List<Table> tables = TableDAO.Instance.readTable();

                Table table = tables.First(t => t.tableTypeId == tableTypeId && t.status == "OFF");

                Console.WriteLine("Table ID is {0}",table.tableId);
                return table.tableId;
            }
            catch
            {
                return null;
            }
        }

        public List<Table> readTable()
        {
            List<Table> listTable = new List<Table>();
            listTable = TableDAO.Instance.readTable();
            return listTable;
        }
    }
}
