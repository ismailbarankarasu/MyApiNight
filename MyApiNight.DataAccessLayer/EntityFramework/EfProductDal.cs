﻿using MyApiNight.DataAccessLayer.Abstract;
using MyApiNight.DataAccessLayer.Context;
using MyApiNight.DataAccessLayer.Repository;
using MyApiNight.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiNight.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(ApiContext context) : base(context)
        {
        }
        ApiContext context = new ApiContext();
        public int GetProductCount()
        {
            int value = context.Products.Count();
            return value;
        }
    }
}
