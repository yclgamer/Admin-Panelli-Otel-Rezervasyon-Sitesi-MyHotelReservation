﻿using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BussinessLayer.Abstract
{
    public interface IBookingService : IGenericService<Booking>
    {
        void TBookingStatusChangeApproved(int id);
        void TBookingStatusChangeCancel(int id);
        void TBookingStatusChangeWaiting(int id);
        int TGetBookingCount();
        List<Booking> TLast6Bookings();
    }
}
