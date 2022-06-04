﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using GUI.Models;

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
       /* public bool ShowAccount(string userName, string passWord)
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
        }*/

        public bool Login(string userName, string passWord)
        {
            List<Account> accounts = AccountDAO.Instance.getAllAccount();
            bool check = accounts.Any(a => a.userName == userName && a.password == passWord);
            return check;
        }


        /*public void showAllAccount()
        {
            List<Account> listedAccount = AccountDAO.Instance.getAllAccount();

            foreach (Account account in listedAccount)
            {
                Console.WriteLine(account.accountEmployeeId);
            }
        }*/


        public bool addAccount (string accountID, string accountType, string username, string displayName, string password)
        {
            return AccountDAO.Instance.createAccount(accountID, accountType, username, displayName, password);
        }

        public int deleteAccountById (string accountId)
        {
            return AccountDAO.Instance.deleteAccount(accountId);
        }

        public int updatedAccountById (string accountId, string newUsername, string newDisplayName, string newPassword )
        {
            return AccountDAO.Instance.updateAccount(accountId, newUsername, newDisplayName, newPassword);
        }
    }
}
