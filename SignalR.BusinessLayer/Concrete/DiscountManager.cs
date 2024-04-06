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
    public class DiscountManager : IDiscountService
    {
        private readonly IDiscountDal _DiscountDal;
        public DiscountManager(IDiscountDal discountDal)
        {
            _DiscountDal = discountDal;
        }
        public void TAdd(Discount entity)
        {
           _DiscountDal.Add(entity);
        }

        public void TDelete(Discount entity)
        {
            _DiscountDal.Delete(entity);
        }

        public Discount TGetById(int id)
        {
            return _DiscountDal.GetById(id);
        }

        public List<Discount> TGetListAll()
        {
           return _DiscountDal.GetListAll();
        }

        public void TUpdate(Discount entity)
        {
            _DiscountDal.Update(entity);
        }
    }
}
