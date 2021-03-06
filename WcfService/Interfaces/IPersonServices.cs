﻿using System.ServiceModel;
using WcfService.Models;

namespace WcfService.Interfaces
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService2" in both code and config file together.
    [ServiceContract]
    public interface IPersonServices
    {
        [OperationContract]
        Person CreatePerson(int id, string name, string middleName);
        
        [OperationContract]
        void DoWork();
    }
}
