using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccsess.Abstract;
using DataAccsess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolves.Autofac
{
    public class AutofacBusinesModule:Module
    {
        //Managerden istifade etmeden servis uzerinden generic tipler ile islemeye imkan verir. Novbeti merhele UI terefde olacaq
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>().InstancePerLifetimeScope();
            builder.RegisterType<EfProductDal>().As<IProductDal>().InstancePerLifetimeScope();

        }
    }
}
