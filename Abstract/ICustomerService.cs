using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopCustomerManagement.Entities;

namespace CoffeeShopCustomerManagement.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer  customer);
    }
}
