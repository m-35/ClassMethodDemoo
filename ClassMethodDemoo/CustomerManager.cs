using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer custom)
        {
            Console.WriteLine("Müşteri bilgileri başarılı bir şekilde eklenmiştir : " + custom.Id + " " + custom.CustomerName + " " + custom.CustomerLastName + " " + custom.TcNumber + " " + custom.IbanNumber);
        }
        public void Listing(Customer custom)
        {
            Console.WriteLine("Müşteri bilgileri başarılı bir şekilde listelenmiştir : " + custom.Id + " " + custom.CustomerName + " " + custom.CustomerLastName + " " + custom.TcNumber + " " + custom.IbanNumber);
        }
        public void Delete(Customer custom)
        {
            Console.WriteLine("Bilgileriniz silinmiştir. " + custom.Id + " " + custom.CustomerName + " " + custom.CustomerLastName + " " + custom.TcNumber + " " + custom.IbanNumber);
        }
    }
}

