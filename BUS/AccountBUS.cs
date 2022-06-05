using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class AccountBUS
    {
        private static AccountBUS instance;

        public static AccountBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountBUS();
                return AccountBUS.instance;
            }
            private set => instance = value;
        }

        //--------------------------------------------------------
        public bool ShowAccount(string userName, string passWord)
        {
            try
            {
                if (AccountDAO.Instance.ShowAccount(userName, passWord) == true)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
