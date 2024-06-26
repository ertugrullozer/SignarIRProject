﻿using SignalIR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SıgnalR.DataAccessLayer.Abstract
{
    public interface IProductDal:IGenericDal<Product>
    {
        //kategori isimlerle birlikte getirme
        //->efproductdal
        List<Product> GetProductWithCategories();
    }
}
