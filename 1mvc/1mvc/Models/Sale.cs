using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _1mvc.Models
{
    public class Sale
    {

        [Key]
        public int SaleID { get; set; }
        public int ProductID { get; set; }
        public int ClientID { get; set; }
        [Required]
        public DateTime Date { get; set; }


    }
}
