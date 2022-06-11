﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI;
using GUI.Models;

namespace DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillDAO();
                return BillDAO.instance;
            }
            private set => instance = value;
        }

        // tạo bill
        public bool createBill(int customerId, string tableId)
        {
            try
            {
                using (var context = new Context())
                {
                    Bill bill = new Bill
                    {
                        customerId = customerId,
                        tableId = tableId,
                        createAt = DateTime.Now,
                        totalPrice = -1
                    };

                    context.Bills.Add(bill);
                    context.SaveChanges();
                }

                return true;

            }
            catch
            {
                return false;
            }
        }


        public bool deleteBill (int id)
        {
            try
            {
                using (var context = new Context())
                {
                    var bill = context.Bills.Find(id);
                    context.Bills.Remove(bill);

                    context.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Bill getBillById(int customerId)
        {
            try
            {
                using (var context = new Context())
                {
                    var bill = context.Bills.SingleOrDefault(c => c.customerId == customerId);
                    return bill;
                    // lấy thông tin hóa đơn thành công
                }
            }
            catch
            {
                return null; // lấy thông tin hóa đơn thất bại
            }
        }

        public List<Bill> getBillIDByTableId(string tableId)
        {
            List<Bill> listBill = new List<Bill>();
            try
            {
                using (var context = new Context())
                {
                    //Lấy ra danh sách các billd có mã bàn trùng với mã bàn được nhập vào và bàn đó còn trống.
                    //(Tại 1 thời điểm 1 bàn trống chỉ tồn tại duy nhất 1 bill)
                    listBill = context.Bills.Where(item => item.tableId == tableId && item.totalPrice == -1).ToList();
                    if (listBill != null)
                        return listBill;
                    else
                        return null;
                }
            }
            catch
            {
                return null;
            }
        }

        public bool updateBill(string tableId, int billId)
        {
            try
            {
                using (var context = new Context())
                {
                    var bill = context.Bills.Where(item => item.billId == billId).FirstOrDefault();
                    if (bill != null)
                    {
                        bill.tableId = tableId;
                        context.SaveChanges();
                        return true;
                    }
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
