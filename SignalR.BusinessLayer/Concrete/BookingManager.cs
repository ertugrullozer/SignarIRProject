using SignalIR.EntityLayer.Entities;
using SignalR.BusinessLayer.Abstract;
using SıgnalR.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
    public class BookingManager : IBookingService
    {
        private readonly IBookingDal _BookingDal;

        public BookingManager(IBookingDal bookingDal)
        {
            _BookingDal = bookingDal;
        }

        public void TAdd(Booking entity)
        {
          _BookingDal.Add(entity);
        }

        public void TDelete(Booking entity)
        {
          _BookingDal.Delete(entity);
        }

        public Booking TGetById(int id)
        {
           return _BookingDal.GetById(id);
        }

        public List<Booking> TGetListAll()
        {
            return _BookingDal.GetListAll();
        }

        public void TUpdate(Booking entity)
        {
          _BookingDal.Update(entity);
        }
    }
}
