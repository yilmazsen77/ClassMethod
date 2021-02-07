using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    public class CustomerManager
    {
        List<Customer> customers = new List<Customer>();

        public void Add(Customer customer)
        {
            customers.Add(customer);
        }

        public void Delete(Customer customer)
        {
            customers.Remove(customer);
            Console.WriteLine("Müsteri " + customer.Name + " silindi.");
        }

        public void List()
        {
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name);
            }
            
        }
    }
}
