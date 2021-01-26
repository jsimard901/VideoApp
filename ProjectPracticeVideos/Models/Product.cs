using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectPracticeVideos.Models
{
    public class Product
    {
    
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int productId {get; set;}

        [Display(Name = "Enter Product Code")]
        [StringLength(20)]
        [Required(ErrorMessage = "{0} is required")]
        public string productCode {get; set;}

        [Display(Name = "Enter Product Type")]
        [StringLength(20)]
        [Required(ErrorMessage = "{0} is required")]
        public string productType {get; set;}

        [Display(Name = "Enter Product Description")]
        [StringLength(150)]
        public string description {get; set;} 

        [Display(Name = "Enter Product Price")]
        [DisplayFormat(DataFormatString = "(0:C)")]
        [Required(ErrorMessage = "{0} is required")]
        public decimal unitPrice {get; set;} 

        [Display(Name = "Quantity in Stock")]
        [Required(ErrorMessage = "{0} is required")]
        public int qtyStock {get; set;} 




    }

}
