
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            /* int a = AccountBUS.Instance.deleteAccountById("EMP3");
             if (a == 1)
                 Console.WriteLine("Deleted Succeedfully");
             else if (a == 0)
                 Console.WriteLine("No Account Has This Id");
             else
                 Console.WriteLine("Deleted Failed!!");*/

            int a = AccountBUS.Instance.updatedAccountById("EM1", "ThanhDuy", "BuiThanhDuy", "123");
            Console.WriteLine("{0}", a);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLoad());
        }
    }
}
