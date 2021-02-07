using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.Id = 1;
            c1.Name = "a";
            c1.EMailAdress = "a@a.com";

            Customer c2 = new Customer();
            c2.Id = 2;
            c2.Name = "b";
            c2.EMailAdress = "b@b.com";

            Customer c3 = new Customer();
            c3.Id = 3;
            c3.Name = "c";
            c3.EMailAdress = "c@c.com";

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(c1);
            customerManager.Add(c2);
            customerManager.Add(c3);


            customerManager.List();

            customerManager.Delete(c1);

            customerManager.List();

            customerManager.Delete(c2);

            customerManager.List();
        }
    }
}
