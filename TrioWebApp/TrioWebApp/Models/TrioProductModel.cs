using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TrioWebApp.Models
{
    [Table("tblProduct")]
    public class TrioProductModel
    {
        public int Id { get; set; }
        public string category { get; set; }
        public string productName { get; set; }
        public int price { get; set; }
        public string description { get; set; }
    }
    
}