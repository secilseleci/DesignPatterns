﻿using RepositoryDesignPattern.BusinessLayer.Abstract;
using RepositoryDesignPattern.DataAccessLayer.Abstract;
using RepositoryDesignPattern.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
 

namespace RepositoryDesignPattern.BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void TDelete(Product t)
        {
            _productDal.Delete(t);
        }
        public void TInsert(Product t)
        {
            _productDal.Insert(t);
        }

        public void TUpdate(Product t)
        {
            _productDal.Update(t);
        }
        public Product TGetById(int id)
        {
           return _productDal.GetById(id);
        }

        public List<Product> TGetList()
        {
            return _productDal.GetList();
                
        }

        public List<Product> TProductListWithCategory()
        {
           return _productDal.ProductListWithCategory();
        }
    }
}
