using System;
using WcfService.Interfaces;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MathServices" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MathServices.svc or MathServices.svc.cs at the Solution Explorer and start debugging.
    public class MathServices : IMathServices
    {
        public int GetSuma(int value1, int value2)
        {
            return value1 + value2;
        }

        public int GetResta(int value1, int value2)
        {
            return value1 - value2;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
