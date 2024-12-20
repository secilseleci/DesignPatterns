﻿using DesignPattern.BusinessLayer.Abstract;
using DesignPattern.DataAccessLayer.Abstract;
using DesignPattern.DataAccessLayer.UnitOfWork;
using DesignPattern.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using UnitOfWorkDesignPattern.DataAccessLayer.EntityFramework;

namespace DesignPattern.BusinessLayer.Concrete
{
    public class ProcessManager : IProcessService
    {
        private readonly IProcessDal _processDal;
        private readonly IUowDal _uowDal;

        public ProcessManager(IProcessDal processDal, IUowDal uowDal)
        {
            _processDal = processDal;
            _uowDal = uowDal;
        }

        public void TDelete(Process t)
        {
            _processDal.Delete(t);
            _uowDal.Save();
        }
        public void TInsert(Process t)
        {
            _processDal.Insert(t);
            _uowDal.Save();
        }
        public void TUpdate(Process t)
        {
            _processDal.Update(t);
            _uowDal.Save();
        }
        public Process TGetById(int id)
        {
            return _processDal.GetById(id);
        }

        public List<Process> TGetList()
        {
            return _processDal.GetList();
        }

        public void TMultiUpdate(List<Process> t)
        {
            _processDal.MultiUpdate(t);
            _uowDal.Save();
        }
    }


}

