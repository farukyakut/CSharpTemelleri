using InterfaceVeAbstractDemo.Abstract;
using InterfaceVeAbstractDemo.Entites;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceVeAbstractDemo.Adapter
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
           // KPSPublicSoapClient client = new KPSPublicSoapClient();
           
        }
    }
}
