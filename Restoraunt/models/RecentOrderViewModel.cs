using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restoraunt.Models
{
    public class RecentOrderViewModel
    {
        public int Id { get; set; }
        public string Buyer { get; set; }
        public DateTime Created { get; set; }
        public decimal Total { get; set; }
        public Restoraunt.Domain.Enums.Order.UState State { get; set; }
    }
}