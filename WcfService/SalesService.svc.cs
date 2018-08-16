using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfService.Interfaces;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SalesService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SalesService.svc or SalesService.svc.cs at the Solution Explorer and start debugging.
    public class SalesService : ISalesService
    {
        public bool DeleteCustomer(int Cid)
        {
            throw new NotImplementedException();
        }

        public void DoWork()
        {
        }

        public List<Customer> GetAllCustomer()
        {
            throw new NotImplementedException();
        }

        public bool InsertCustomer(Customer obj)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCustomer(Customer obj)
        {
            throw new NotImplementedException();
        }
    }
}
