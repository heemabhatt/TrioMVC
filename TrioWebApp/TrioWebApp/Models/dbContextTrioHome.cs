using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace TrioWebApp.Models
{
    public class dbContextTrioHome : DbContext
    {
        public dbContextTrioHome() : base("cnContextTrioHome") {   }
        public DbSet<TrioHomeModel> TrioHomeModels { get; set; }

 
        public DbSet<TrioProductModel> DBTrioProductModels { get; set; }
    }
}