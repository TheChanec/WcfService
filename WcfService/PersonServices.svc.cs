using WcfService.Interfaces;
using WcfService.Models;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PersonServices" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PersonServices.svc or PersonServices.svc.cs at the Solution Explorer and start debugging.
    public class PersonServices : IPersonServices
    {
        public Person CreatePerson(int id, string name, string middleName)
        {
            return new Person { Id = id, Name = name, MiddleName = middleName };
        }

        public void DoWork()
        {
        }
    }
}
