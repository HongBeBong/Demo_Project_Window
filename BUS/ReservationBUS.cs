using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using GUI.Models;

namespace BUS
{
    public class ReservationBUS
    {
        private static ReservationBUS instance;

        public static ReservationBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new ReservationBUS();
                return ReservationBUS.instance;
            }
            private set => instance = value;
        }

        public bool addReservation (int customerId, string tableId, DateTime confirmTime )
        {
            return ReservationDAO.Instance.createReservation(customerId, tableId, confirmTime);
        }

        /*public Customer getCustomerIdByTableId (string tableId)
        {
            return ReservationDAO.Instance.getBookingInformation(tableId);
        }*/


        
    }
}
