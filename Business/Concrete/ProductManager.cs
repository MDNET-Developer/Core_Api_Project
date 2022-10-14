using Business.Abstract;
using DataAccsess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    internal class ProductManager : IProductService
    {
        private IProductDal _productDal;
        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public Product GetById(int id)
        {
          return  _productDal.Get(x=>x.ProductId==id);
        }

        public List<Product> GetList()
        {
            return _productDal.Getlist().ToList();
        }

        public List<Product> GetListbyCategoryId(int categoryId)
        {
            return _productDal.Getlist(x=>x.CategoryId==categoryId).ToList();
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
