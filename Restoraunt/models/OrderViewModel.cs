using Restoraunt.Domain.Entities.Product;
using Restoraunt.Domain.Enums.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restoraunt.Models
{
	public class OrderViewModel
	{
        public int Id { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public UState State { get; set; }
        public decimal Total { get; set; }
        public ICollection<ProductViewModel> Products { get; set; }
    }
}