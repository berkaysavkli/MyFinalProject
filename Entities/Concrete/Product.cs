
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product
        //class ı public yaptığımız zaman diğer katmanlardan erişilebilmesini sağlar
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public short UnitInStock  { get; set; }
        public decimal UnitPrice  { get; set; }

    }
    
}
