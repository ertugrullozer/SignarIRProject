using SignalIR.EntityLayer.Entities;
using SıgnalR.DataAccessLayer.Abstract;
using SıgnalR.DataAccessLayer.Concrete;
using SıgnalR.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SıgnalR.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(SignalRContext signalRContext) : base(signalRContext)
        {
        }
    }
}
