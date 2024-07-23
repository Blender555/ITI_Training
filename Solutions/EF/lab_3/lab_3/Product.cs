using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    public class Product
    {
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public decimal Tax { get; set; } = 10;
        public decimal TotalPrice { get; private set; }
    }
}
