using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void AddCustomer (Customer customer) 
        {
            Console.WriteLine("Customer added! : " + customer.Name + " " + customer.Surname);
        }

        public void DelCustomer(Customer customer) 
        {
            Console.WriteLine("Customer deleted ! : " + customer.Name + " " + customer.Surname);
        }

        public void ListCustomers(Customer[] customers) 
        {
            foreach (var item in customers)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Surname);
                Console.WriteLine(item.Id);
            }
        }
    }
}
