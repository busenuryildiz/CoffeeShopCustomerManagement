using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopCustomerManagement.Abstract;
using CoffeeShopCustomerManagement.Entities;
using MernisServiceReference;

namespace CoffeeShopCustomerManagement.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            Task<TCKimlikNoDogrulaResponse> tcKimlikTask = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId), customer.FirstName, customer.LastName, customer.DateOfBirth.Year);
            return tcKimlikTask.Result.Body.TCKimlikNoDogrulaResult; 
        }
    }
}
