﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restoraunt.Domain.Entities.Product
{
    public class ProductDbModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, StringLength(120)]
        public string Title { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        [NotMapped] 
        public int Quantity { get; set; } = 1;
        [NotMapped] 
        public string ProductName { get => Title; set => Title = value; }
        [StringLength(260)]
        public string ImageUrl { get; set; }
    }
}
