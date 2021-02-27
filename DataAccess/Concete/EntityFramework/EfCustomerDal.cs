using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concete.EntityFramework
{
    public class EfCustomerDal: EfEntityRepositoryBase<Customer,NorthwindContext>,ICustomerDal
    {
    }
}
