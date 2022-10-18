using Business.Abstract;
using Core.Utilities.Abstract;
using Core.Utilities.Class;
using Core.Utilities.DataAbstract;
using Core.Utilities.DataClass;
using Core.Utilities.Messages.Product;
using DataAccsess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        public IResult Add(Product product)
        {
            _productDal.Add(product);
            return new SuccessResult(message: ProductMessages.AddedProduct, succsess: true);
        }

        public IResult Delete(Product product)
        {
            _productDal.Delete(product);
            return new SuccessResult(message: ProductMessages.DeletedProduct, succsess: true);
        }

        public IDataResult<Product> GetById(int id)
        {
          return new SuccessDataResult<Product>(_productDal.Get(x=>x.ProductId==id));
        }

        public IDataResult<List<Product>> GetList()
        {
            return new SuccessDataResult<List<Product>>(_productDal.Getlist().ToList());
        }

        public IDataResult<List<Product>>GetListbyCategoryId(int categoryId)
        {
            return new SuccessDataResult<List<Product>>(_productDal.Getlist(x=>x.CategoryId==categoryId).ToList());
        }

        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult(message:ProductMessages.UptatedProduct,succsess:true);
        }
    }
}
