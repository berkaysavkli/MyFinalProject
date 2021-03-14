using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //EfProductDal yerine InMemoryProductDal yazarsak memeory de çalışmış oluruz.
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetAllByCategoryId(2))
                // productManager. dan sonraki kısmı değiştirerek  yazdığımız farklı filtremelere
                //göre verileri getiririz.
             
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
