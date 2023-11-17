using CoffeeShopCustomerManagement.Abstract;
using CoffeeShopCustomerManagement.Adapters;
using CoffeeShopCustomerManagement.Concrete;
using CoffeeShopCustomerManagement.Entities;

namespace CoffeeShopCustomerManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer{DateOfBirth = new DateTime(2000,04,01),FirstName = "Buse",LastName = "Yıldız", NationalityId = "55555555555"});
            Console.ReadLine();
        }
    }
}