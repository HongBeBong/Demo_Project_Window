using GUI;
using GUI.Models;
using GUI.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ReservationDAO
    {
        private static ReservationDAO instance;
        public static ReservationDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ReservationDAO();
                return ReservationDAO.instance;
            }
            private set => instance = value;
        }

        //Hàm thêm 1 đối tượng Reservation 
        public bool createReservation(int customerID, string tableId, DateTime confirmTime)
        {
            try
            {
                using (var con = new Context())
                {
                    Reservation reservation = new Reservation() { customerId = customerID, tableId = tableId, confirmTime = confirmTime };
                    con.Reservations.Add(reservation);
                    con.SaveChanges();
                    return true;// Nếu thêm thành công trả về true
                }    
            }
            catch
            {
                // Nếu có lỗi ở phần xử lí phía trên trả về false
                return false;
            }
        }

        // Hàm lấy các đối tượng Reservation lên để xem 
        public List<Reservation> readReservation()
        {
            try
            {
                using (Context con = new Context())
                {
                    var listReservation = con.Reservations.ToList();
                    return listReservation;// Trả về danh sách các đội tượng Reservation 
                }
            }
            catch
            {
                // Nếu có lỗi ở phần xử lí phía trên trả về false
                return null;
            }
        }

        //Hàm Update 1 đối tượng Reservation
        public bool updateReservation(int customerID, string tableId, DateTime confirmTime)
        {
            try
            {
                using (var con = new Context())
                {
                    // Lấy ra đối tượng Reservation đầu tiên thỏa điều kiện trong Where
                    Reservation reservation = con.Reservations.Where(item => item.customerId == customerID && item.tableId == tableId).First();
                    // Nếu lấy ra được 1 đối tượng thỏa điều kiện thì tiến hành Update
                    if (reservation != null)
                    {
                        reservation.customerId = customerID;
                        reservation.tableId = tableId;
                        reservation.confirmTime = confirmTime;
                        con.SaveChanges();
                        return true;
                    }
                    //Ngược lại thì trả về true
                    else
                    {
                        return false;
                    }
                }
            }
            catch
            {
                // Nếu có lỗi ở phần xử lí phía trên trả về false
                return false;
            }
        }

        // Hàm xóa đi 1 đối tượng Reservation 
        public bool deleteReservation(int customerID, string tableId)
        {
            try
            {
                using (var con = new Context())
                {
                    // Lấy ra đối tượng Reservation đầu tiên thỏa điều kiện trong Where
                    Reservation reservation = con.Reservations.Where(item => item.customerId == customerID && item.tableId == tableId).First();
                    // Nếu lấy ra được 1 đối tượng thỏa điều kiện thì tiến hành Delete
                    if (reservation != null)
                    {
                        con.Reservations.Remove(reservation);
                        con.SaveChanges();
                        return true;
                    }
                    // Ngược lại thì trả về true
                    else
                    {
                        return false;
                    }
                }
            }
            catch
            {
                // Nếu có lỗi ở phần xử lí phía trên trả về false
                return false;
            }
        }
    }
}
