﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            _brandDal.Add(brand);
        }

        public void AddBrand(Brand brand)
        {
            if (brand.BrandName.Length > 2)
            {
                Console.WriteLine("Model ismi sisteme başarıyla eklendi");
            }
            else
            {
                Console.WriteLine("Model ismi en az 2 karakter olmalıdır!");
            }
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }
    }
}
