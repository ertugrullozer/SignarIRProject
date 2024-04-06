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
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _CategoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _CategoryDal = categoryDal;
        }
        public void TAdd(Category entity)
        {
          _CategoryDal.Add(entity);
        }

        public void TDelete(Category entity)
        {
            _CategoryDal.Delete(entity);
        }

        public Category TGetById(int id)
        {
           return _CategoryDal.GetById(id);
        }

        public List<Category> TGetListAll()
        {
            return _CategoryDal.GetListAll();
        }

        public void TUpdate(Category entity)
        {
           _CategoryDal.Update(entity);
        }
    }
}
