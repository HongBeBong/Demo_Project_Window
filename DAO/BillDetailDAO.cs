using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI;
using GUI.Models;

namespace DAO
{
    public class BillDetailDAO
    {
        private static BillDetailDAO instance;

        public static BillDetailDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillDetailDAO();
                return BillDetailDAO.instance;
            }
            private set => instance = value;
        }

        // hàm tạo bill detail
        public bool createBillDetail (int billId, string dishId, int quantity)
        {
            try
            {

                using (var context = new Context())
                {

                    BillDetail bDetail = new BillDetail()
                    {
                        billId = billId,
                        dishId = dishId,
                        quatity = quantity,
                    };

                    context.BillDetails.Add(bDetail);
                    context.SaveChanges();
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        // lấy các món ăn và số lương tương ứng cho từng bill
        public List<BillDetail> getAllBillDetails(int id)
        {
            try
            {
                using (var context = new Context())
                {
                    var listBillDetail = context.BillDetails.Where(bd => bd.billId == id);
                    return listBillDetail.ToList();
                }
            }
            catch
            {
                return null;
            }
        }

        public bool deleteBillDetail(int billId, string dishID)
        {
            try
            {
                using (var context = new Context())
                {
                    var bill = context.BillDetails.Where(item => item.billId == billId && item.dishId == dishID).First();
                    context.BillDetails.Remove(bill);

                    context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool updateBillDetail(int billId, string dishId, int quantity)
        {
            try
            {
                //Nếu bill đang xét không có trong bảng Bill thì không update
                if (billId == null)
                    return false;

                using (var context = new Context())
                {
                    var checkBillDetail = context.BillDetails.Where(item => item.billId == billId && item.dishId == dishId).FirstOrDefault();
                    
                    //Nếu món có tồn tại trong danh sách các món đã order 
                    if (checkBillDetail != null)
                    {
                        //Nếu số lượng món đưa vào là âm và số lượng món ban đầu cộng với số lượng món mới đưa vào nhỏ hơn bằng 0
                        // thì đồng nghĩa với việc xóa món đó khỏi danh sách order.
                        if (quantity + checkBillDetail.quatity <= 0)
                        {
                            deleteBillDetail(billId, dishId);
                            return true;
                        }
                        else
                        {
                            checkBillDetail.quatity = checkBillDetail.quatity + quantity;
                            context.SaveChanges();
                            return true;
                        }
                    }
                    //Nếu món đang xét chưa có trong danh sách món thì add mới 
                    else
                    {
                        if (quantity <= 0)
                        {
                            quantity = 1;
                        }

                        BillDetail billDetail = new BillDetail() { billId = billId, dishId = dishId, quatity = quantity };
                        context.BillDetails.Add(billDetail);
                        context.SaveChanges();
                        return true;
                    }
                }
            }
            catch
            { 
               return false;
            }
        }
    }
}
