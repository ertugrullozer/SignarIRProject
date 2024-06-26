﻿using Microsoft.EntityFrameworkCore;
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
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(SignalRContext signalRContext) : base(signalRContext)
        {
        }

        public List<Product> GetProductWithCategories()
        {
            //verileri isimlerle birlikte getirme 
            //-> databusiness- ıproductservice
            var context = new SignalRContext();
            var values= context.Products.Include(x=>x.Category).ToList();
            return values;
        }
    }
}
