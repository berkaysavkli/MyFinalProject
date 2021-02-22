using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
                new Product{ProductId=1,CategoryId=1,ProductName="Bardak",UnitPrice=15,UnitInStock=15},
                new Product{ProductId=2,CategoryId=1,ProductName="Kamera",UnitPrice=500,UnitInStock=3},
                new Product{ProductId=3,CategoryId=2,ProductName="Telofon",UnitPrice=1500,UnitInStock=2},
                new Product{ProductId=4,CategoryId=2,ProductName="Klavye",UnitPrice=150,UnitInStock=65},
                new Product{ProductId=5,CategoryId=2,ProductName="Fare",UnitPrice=85,UnitInStock=1},
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
  
        }

        public void Delete(Product product)
        {
            //LİNQ kullanarak listeyi dolaşma
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            //SingleOrDefault her ürünü dolaşmaya yarar
            _products.Remove(productToDelete);
   
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        // Kategoriye göre listeleme işini yapar
        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            //Gönderdiğim ürün Id'sine sahip olan listedeki ürünü bul
            Product productToUpdate = _products.SingleOrDefault(p => product.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitInStock = product.UnitInStock;
        }
    }
}
