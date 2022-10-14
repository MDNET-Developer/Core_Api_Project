using Core.EfEntityGenericBase;
using DataAccsess.Abstract;
using DataAccsess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.Concrete.EntityFramework
{
    public class EfProductDal : EfRepositoryBaseGeneric<Product, NorthwindContext>
    {
    }
}
