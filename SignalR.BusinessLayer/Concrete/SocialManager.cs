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
    public class SocialManager : ISocialMediaService
    {
        public readonly ISocialMediaDal _SocialMedia;
        public SocialManager(ISocialMediaDal socialMediaDal)
        {
            _SocialMedia = socialMediaDal;
        }
        public void TAdd(SocialMedia entity)
        {
            _SocialMedia.Add(entity);
        }

        public void TDelete(SocialMedia entity)
        {
           _SocialMedia.Delete(entity);
        }

        public SocialMedia TGetById(int id)
        {
            return _SocialMedia.GetById(id);
        }

        public List<SocialMedia> TGetListAll()
        {
            return _SocialMedia.GetListAll();
        }

        public void TUpdate(SocialMedia entity)
        {
            _SocialMedia.Update(entity);
        }
    }
}
