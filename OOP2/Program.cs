using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Individual individual1 = new Individual();
            individual1.CustomerNo = "12345";
            individual1.Name = "Volkan";
            individual1.Surname = "Ulker";
            individual1.IdentityNo = "22666674852";


            Coorporate coorporate1 = new Coorporate();
            coorporate1.Id = 2;
            coorporate1.CustomerNo = "54321";
            coorporate1.CompanyName = "Softtech";
            coorporate1.TaxNo = "123456789";


            Customer customer1 = new Individual();

            Customer customer2 = new Coorporate();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);



        }
    }
}
