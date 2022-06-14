using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
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

        public Bill getBillById(int billId)
        {
            try
            {
                using (var context = new Context())
                {
                    var bill = context.Bills.SingleOrDefault(c => c.billId == billId);
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

        // hàm lấy billId bằng customerID và table ID và trạng thái bill

        public int getBillId(int customerId, string tableID)
        {
            try
            {
                using (var context = new Context())
                {
                    var bill = context.Bills.Where(b => b.customerId == customerId 
                                                && b.tableId == tableID && b.totalPrice == -1)
                                                .FirstOrDefault();
                    if (bill != null)
                    {
                        return bill.billId;
                    }
                    return -1;
                   
                }
            }
            catch (Exception e)
            {
                return -1;
            }
        }


        public void getDataGridViewInfomation(DataGridView dgv,  int billId)
        {
            try
            {
                using (var context = new Context())
                {
                    var info = context.Bills.Join(context.BillDetails,
                        bill => bill.billId,
                        billdetail => billdetail.billId,
                        (bill, billdetail) => new
                        {
                            billId = bill.billId,
                            totalPrice = bill.totalPrice,
                            dishId = billdetail.dishId,
                            quantity = billdetail.quatity,
                        })
                        .Where(x => x.totalPrice == -1 && x.billId == billId)
                        .Join(context.Dishes,
                                i => i.dishId,
                                dish => dish.dishId,
                            (i, dish) => new
                            {
                                dishName = dish.dishName,
                                quantity = i.quantity,
                                price = dish.price,
                                total = dish.price * i.quantity
                            }) ;
                    var listInfo = info.ToList();

                    dgv.DataSource = listInfo;
                }
            }
            catch
            {
                MessageBox.Show("Lấy thông tin thất bại");
            }
        }


        // cập nhật thông tin bill và tên nhân viên
        public bool updateEmployeeAndTime(int billId, string employeeId, int total)
        {
            try
            {
                using (var context = new Context())
                {
                    var bill = context.Bills.Where(item => item.billId == billId).FirstOrDefault();
                    if (bill != null)
                    {
                        bill.createAt = DateTime.Now;
                        bill.employeeId = employeeId;
                        bill.totalPrice = total;
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

        public int getCustomerIdByTableIdAndToTal (string tableId, int totalprice)
        {
            try
            {
                using (var context = new Context())
                {
                    var billrecord = context.Bills.Where(b => b.tableId == tableId && b.totalPrice == totalprice).FirstOrDefault();
                    return billrecord.customerId; 
                }
            }
            catch
            {
                return -1;
            }
        }


        

    }


}

