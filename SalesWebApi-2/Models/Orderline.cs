using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebApi_2.Models
{
    public class Orderline
    {
        public int Id { get; set; }
        [StringLength(30),Required]
        public string Name { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName ="decimal(11,2)")]
        public decimal Price { get; set; }
        public int OrderId { get; set; }

        public virtual Order Order { get; set; }

    }
}
