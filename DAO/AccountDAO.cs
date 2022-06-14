using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using DTO.Migrations;
using GUI;
using GUI.Maps;
using GUI.Models;
using System.Data.Entity;

namespace DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        Context db = new Context();

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountDAO();
                return AccountDAO.instance;
            }
            private set => instance = value;
        }
        //--------------------------------------------

        public List<Account> GetListAccount()
        {
            return db.Accounts.ToList();
        }
        public bool ShowAccount(string userName, string passWord)
        {
            try
            {
                using (var context = new Context())
                {
                    bool accountList = context.Accounts.Any(item => item.userName.Equals(userName) && item.password.Equals(passWord));
                    return accountList;
                }
            }
            catch
            {
                return false;
            }
        }
        public bool addAccount(Account a)// them account
        {
            // lấy tất cả tài khoản trong list Account
            try
            {


                if (a != null)
                {
                    db.Accounts.Add(a);
                    db.SaveChanges();
                    return true;
                }
                return false;

            }
            catch (Exception)
            {
                return false;
            }
            
        }
        public bool DeleteAccount(string accountEmployeeId)// xóa 1 account
        {
            Account e = db.Accounts.Where(d => d.accountEmployeeId == accountEmployeeId).FirstOrDefault();
            try
            {
                if (e != null)
                {
                    db.Accounts.Remove(e);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception )
            {
                return false;
            }
        }
        public bool editAccount(Account a)// sua 1 account
        {
            try
            {
                if (a != null)
                {
                    Account aTmp = db.Accounts.Where(d => d.accountEmployeeId == a.accountEmployeeId).FirstOrDefault();
                    if (aTmp == null)
                        return false;
                    aTmp.accountEmployeeId = a.accountEmployeeId;
                    aTmp.accountType = a.accountType;
                    aTmp.userName = a.userName;
                    aTmp.displayName = a.displayName;
                    aTmp.password = a.password;
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
                    {
                return false;
                    }
                    else 
                        return 0; // không có tài khoản cần tìm
                }
        public bool CheckAdmin(string accountType)// kiem tra admin
        {
            var x = db.Accounts.Where(n => n.accountType == accountType && n.accountType == "Admin").ToList();
            return (x.Any()) ? true : false;
            }
        public int GetAccountEmployeeID(string accountEmployeeId, ref string error)
        {
            try
            {
                if (accountEmployeeId != null)
            {
                    var x = db.Accounts.Where(n => n.accountEmployeeId == accountEmployeeId).FirstOrDefault();
                    error = "Get Employee Success";
                    return 1;
            }
                return -1;
        } 
            catch
            {

                return -1;
            }

        }
        public Account FindAccount(string accountEmployeeId)
        {
            try
            {
                if (accountEmployeeId != null)
                {
                    return db.Accounts.Where(x => x.accountEmployeeId == accountEmployeeId).FirstOrDefault();
                }
                return null;
            }
            catch
            {
                return null;
            }

        }

    }
}
