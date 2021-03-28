using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapProjectContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from r in context.Rentals
                             join c in context.Customers
                             on r.CustomerId equals c.CustomerId
                             join car in context.Cars
                             on r.CarId equals car.Id
                             join b in context.Brands
                             on car.BrandId equals b.BrandId
                             join color in context.Colors
                             on car.ColorId equals color.ColorId
                             select new RentalDetailDto
                             {
                                 RentalId = r.Id,
                                 CustomerId = c.CustomerId,
                                 FirstName = c.FirstName,
                                 LastName = c.LastName,
                                 CarId = car.Id,
                                 BrandName = b.BrandName,
                                 ModelName = car.ModelName,
                                 ColorName = color.ColorName,
                                 RentDate =r.RentDate,
                                 ReturnDate = r.ReturnDate

                             };
                   
                return result.ToList();
            }
        }
    }
}
