using InterfaceVeAbstractDemo.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceVeAbstractDemo.Abstract
{
    public abstract class BaseCostumerManager : ICustomerService
    {
        //virtual , save fonksiyonun ezilmesine izin verdi
        public virtual void Save(Customer customer)
        {
            Console.WriteLine(" Müşteri veri tabanına Eklendi : {} " + customer.FirstName);
        }
    }
}
