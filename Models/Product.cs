using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test.Models
{
    public class Product
    {
        [Key]
        [Display(Name = "Product id")]
        public int product_id { get; set; }

        //store

        [StringLength(50), Display(Name = "External Product ID")]
        public string external_productid { get; set; }

        [StringLength(100), Display(Name = "Name")]
        [Required(ErrorMessage = "The Name {0} is required")]
        public string product_name { get; set; }

        [StringLength(1000), Display(Name = "Description")]
        public string product_description { get; set; }

        [Required(ErrorMessage = "The Unit Price {0} is required")]
        [Display(Name = "Unit Price")]
        [Column(TypeName = "decimal(18,3)")]
        public decimal unitprice { get; set; }

    }
}
