using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Product
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public DateTime ExpirationDate { get; set; }

        public override string ToString()
        {
            return $"{Name};{Price:0.00};{ExpirationDate:yyyy-MM-dd}";
        }
    }
}
