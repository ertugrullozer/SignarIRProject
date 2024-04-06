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
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactService;

        public ContactManager(IContactDal contactDal)
        {
            _contactService = contactDal;
        }
        public void TAdd(Contact entity)
        {
            _contactService.Add(entity);
        }

        public void TDelete(Contact entity)
        {
          _contactService.Delete(entity);
        }

        public Contact TGetById(int id)
        {
           return _contactService.GetById(id);
        }

        public List<Contact> TGetListAll()
        {
            return _contactService.GetListAll();
        }

        public void TUpdate(Contact entity)
        {
          _contactService.Update(entity);
        }
    }
}
