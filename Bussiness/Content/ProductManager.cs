using Bussiness.Services;
using Data.Abstract;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Content
{
    public class ProductManager : IGenericService<Product>, IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void TAdd(Product t)
        {
        _productDal.Insert(t);  
        }

        public void TDelete(Product t)
        {
          _productDal.Delete(t);
        }

        public Product TGetById(int id)
        {
           return _productDal.GetById(id);  
        }

        public List<Product> TGetList()
        {
           return _productDal.GetList();
        }

        public void TUpdate(Product t)
        {
          _productDal.Update(t);
        }
    }
}
