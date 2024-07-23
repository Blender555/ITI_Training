using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required]
        public string Name { get; set; }

        [StringLength(100)]
        public string Email { get; set; }
        public int Age { get; set; }
    }
}
