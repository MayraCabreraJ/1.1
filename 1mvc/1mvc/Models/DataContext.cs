using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _1mvc.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<_1mvc.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<_1mvc.Models.Client> Clients { get; set; }
    }
}