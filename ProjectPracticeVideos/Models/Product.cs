using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectPracticeVideos.Controllers
{
    public class Product
    {
    
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int productId {get; set;}

        public string productCode {get; set;} 
        public string description {get; set;} 
        public decimal unitPrice {get; set;} 
        public int qtyStock {get; set;} 




    }

}
