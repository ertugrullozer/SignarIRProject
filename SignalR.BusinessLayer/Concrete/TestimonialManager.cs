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
    public class TestimonialManager : ITestiMonialService
    {
        private readonly ITestimonialDal _TestiMonial;
        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _TestiMonial = testimonialDal;
        }
        public void TAdd(Testimonial entity)
        {
          _TestiMonial.Add(entity);
        }

        public void TDelete(Testimonial entity)
        {
            _TestiMonial.Delete(entity);
        }

        public Testimonial TGetById(int id)
        {
           return _TestiMonial.GetById(id);
        }

        public List<Testimonial> TGetListAll()
        {
            return _TestiMonial.GetListAll();
        }

        public void TUpdate(Testimonial entity)
        {
          _TestiMonial.Update(entity);
        }
    }
}
