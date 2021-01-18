using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Name = "Ömer";
            customer1.Surname = "Biltekin";
            customer1.Id = "1000000001";

            Customer customer2 = new Customer();
            customer2.Name = "Caner";
            customer2.Surname = "Yılmaz";
            customer2.Id = "1000000002";

            Customer customer3 = new Customer();
            customer3.Name = "Ahmet";
            customer3.Surname = "Su";
            customer3.Id = "1000000003";

            Customer customer4 = new Customer();
            customer4.Name = "Selim";
            customer4.Surname = "Meriç";
            customer4.Id = "1000000004";

            Customer[] customers = new Customer[] {customer1, customer2 , customer3 , customer4 };


            CustomerManager customerManager = new CustomerManager();

            Console.WriteLine("------ Customer Add ------");
            customerManager.AddCustomer(customer1);
            customerManager.AddCustomer(customer2);

            Console.WriteLine("------ Customer Delete ------");
            customerManager.DelCustomer(customer3);

            Console.WriteLine("------ Customers List ------");
            customerManager.ListCustomers(customers);


        }
    }
}
