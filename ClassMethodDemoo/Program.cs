using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer custom1 = new Customer();
            custom1.Id = 1245467;
            custom1.CustomerName = "Ayşe";
            custom1.CustomerLastName = "PARLAK";
            custom1.TcNumber = 335587964451;
            custom1.IbanNumber = 250145360004;

            Console.WriteLine("-----------------------------------------");

            Customer custom2 = new Customer();
            custom2.Id = 5489644;
            custom2.CustomerName = "Ebru";
            custom2.CustomerLastName = "KUYTU";
            custom2.TcNumber = 36678452155;
            custom2.IbanNumber = 560005554779;



            Customer[] customers = new Customer[] { custom1, custom2 };
            foreach (Customer custom in customers)
            {

                Console.WriteLine(custom.Id);
                Console.WriteLine(custom.CustomerName);
                Console.WriteLine(custom.CustomerLastName);
                Console.WriteLine(custom.TcNumber);
                Console.WriteLine(custom.IbanNumber);


            }

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("EKLENENLER");
            CustomerManager customs = new CustomerManager();
            customs.Add(custom1);
            customs.Add(custom2);

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine(" LİSTELENENLER ");
            customs.Listing(custom1);
            customs.Listing(custom2);

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine(" SİLİNENLER ");
            customs.Delete(custom1);





        }
    }
}

