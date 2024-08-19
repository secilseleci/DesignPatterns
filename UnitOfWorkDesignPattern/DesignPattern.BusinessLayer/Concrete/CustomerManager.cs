﻿using DesignPattern.BusinessLayer.Abstract;
using DesignPattern.DataAccessLayer.Abstract;
using DesignPattern.DataAccessLayer.UnitOfWork;
using DesignPattern.EntityLayer.Concrete;
using System;
using System.Collections.Generic;

namespace DesignPattern.BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;
        private readonly IUowDal _uowDal;

        public CustomerManager(ICustomerDal customerDal, IUowDal uowDal)
        {
            _customerDal = customerDal;
            _uowDal = uowDal;
        }

        public void TDelete(Customer t)
        {
            _customerDal.Delete(t);
            _uowDal.Save();
        }
        public void TInsert(Customer t)
        {
            _customerDal.Insert(t);
            _uowDal.Save();

        }
        public void TUpdate(Customer t)
        {
            _customerDal.Update(t);
            _uowDal.Save();

        }
        public Customer TGetById(int id)
        {
            return _customerDal.GetById(id);
        }

        public List<Customer> TGetList()
        {
            return _customerDal.GetList();
        }

        public void TMultiUpdate(List<Customer> t)
        {
           _customerDal.MultiUpdate(t);
            _uowDal.Save();
        }
    }


}

