﻿using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class Treasurer : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context=new Context();
            if (req.Amount <= 100000)
                { 
                    CustomerProcess customerProcess = new CustomerProcess();
                    customerProcess.Amount=req.Amount.ToString();
                    customerProcess.Name=req.Name;
                    customerProcess.EmployeeName="Veznedar - Ali Çınar";
                    customerProcess.Description= "Para çekme işlemi onaylandı. Müşteriye talep ettiği tutar ödendi.";
                    context.CustomerProcesses.Add(customerProcess);
                    context.SaveChanges();
                }
            else if(NextApprover is not null) 
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Veznedar - Ali Çınar";
                customerProcess.Description = "Para çekme tutarı veznedarın günlük ödeyebileceği limiti aştığı için işlem Şube Müdür Yardımcısına yönlendirildi.";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(req);
            }
        }
    }
}
