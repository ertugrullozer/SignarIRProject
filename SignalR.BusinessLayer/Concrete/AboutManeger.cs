using SignalIR.EntityLayer.Entities;
using SignalR.BusinessLayer.Abstract;
using SıgnalR.DataAccessLayer.Abstract;

namespace SignalR.BusinessLayer.Concrete
{
    public class AboutManeger : IAboutService
    {
    
        private readonly IAboutDal _aboutDal;
        public AboutManeger(IAboutDal aboutService)
        {
            _aboutDal = aboutService;
        }

        public void TAdd(About entity)
        {
           _aboutDal.Add(entity);
        }

        public void TDelete(About entity)
        {
            _aboutDal.Delete(entity);
        }

        public About TGetById(int id)
        {
         return _aboutDal.GetById(id);

        }

        public List<About> TGetListAll()
        {
            return _aboutDal.GetListAll();
        }

        public void TUpdate(About entity)
        {
           _aboutDal.Update(entity);
        }
    }
}
