using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebShopper.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Min 3 and Max 100 chars are allowed", MinimumLength = 3)]
        public string ProductName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Min 3 and Max 50 chars are allowed", MinimumLength = 3)]
        public string Category { get; set; }

        public bool IsActive { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public Nullable<System.DateTime> CreatedDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public Nullable<System.DateTime> ModifiedDate { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "1", "200000", ErrorMessage = "Invalid price")]
        public decimal Price { get; set; }
    }
}