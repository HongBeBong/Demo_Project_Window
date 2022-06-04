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



    }
}
