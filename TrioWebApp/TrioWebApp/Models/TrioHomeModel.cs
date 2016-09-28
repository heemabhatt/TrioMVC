using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrioWebApp.Models
{
    [Table("tblContactUs")]
    public class TrioHomeModel
    {
        [Key]
        public int Id { get; set; }

        public string fullName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string comment { get; set; }
    }

   
}