using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI;
using GUI.Models;
using System.Data.Entity;

namespace DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

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
      /*  public bool ShowAccount(string userName, string passWord)
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
        }*/

        public List<Account> getAllAccount()
        {
            // lấy tất cả tài khoản trong list Account
            try
            {
                using (var context = new Context())
                {
                    var allAccount = context.Accounts;
                    return allAccount.ToList();
                }
            }
            catch
            {
                Console.WriteLine("load data failed");
                return null;
            }
            
        }

        public bool createAccount(string accountEmployeeId, string accountType, string userName, string displayName, string password)
        {
            try
            {
                // tạo một account mới, thông tin lấy từ GUI
                var account = new Account
                {
                    accountEmployeeId = accountEmployeeId,
                    accountType = accountType,
                    userName = userName,
                    displayName = displayName,
                    password = password
                };

                // thêm và xác nhận thêm vào database
                using (var context = new Context())
                {
                    context.Accounts.Add(account);
                    context.SaveChanges();
                }
                return true; // thêm tài khoản thành cônng
            }
            catch
            {
                Console.WriteLine("Thêm tài khoản không thành công");
                return false; // thêm tài khoản không thành công
            }
        }


        public int deleteAccount (string accountEmployeeId)
        {
            try
            {
                using (var context = new Context())
                {
                    var deletedAccount = context.Accounts.First(a => a.accountEmployeeId == accountEmployeeId);
                    if (deletedAccount != null)
                    {
                        context.Accounts.Remove(deletedAccount);
                        context.SaveChanges();
                        return 1; // xóa thành công
                    }
                    else 
                        return 0; // không có tài khoản cần tìm
                }
            }
            catch
            {
                return -1; // xóa thất bại
            }
        } 


        public int updateAccount (string accountID, string newUserName,string newDisplayName, string newPassword )
        {
            try
            {

                using (var context = new Context ())
                {
                    var account = context.Accounts.Find(accountID);
                    if (account == null) 
                        return 0; // không tìm thấy tài khoản
                    account.userName = newUserName;
                    account.displayName = newDisplayName;
                    account.password = newPassword;
                    context.SaveChanges();
                    return 1; // cập nhật thành công
                }
            }
            catch
            {
                Console.WriteLine("Changed acount information failed !!!");
                return -1; //cập nhật thất bại
            }
        }

    }
}
