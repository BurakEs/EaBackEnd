using Business.Concrete;
using DataAccess.Concete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var p in productManager.GetByUnitPrice(10,20))
            {
                Console.WriteLine(p.ProductName);
            }
        }
    }
}
