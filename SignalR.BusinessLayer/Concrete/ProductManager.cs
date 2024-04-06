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
    public class ProductManager : IProductService
    {
        private readonly IProductDal _ProductDal;
        public ProductManager(IProductDal productDal)
        {
            _ProductDal=productDal;
        }
        public void TAdd(Product entity)
        {
            _ProductDal.Add(entity);
        }

        public void TDelete(Product entity)
        {
            _ProductDal.Delete(entity);
        }

        public Product TGetById(int id)
        {
           return _ProductDal.GetById(id);
        }

        public List<Product> TGetListAll()
        {
          return _ProductDal.GetListAll();
        }

        public void TUpdate(Product entity)
        {
           _ProductDal.Update(entity);
        }
    }
}
