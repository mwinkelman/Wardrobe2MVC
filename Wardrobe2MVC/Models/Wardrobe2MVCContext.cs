using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Wardrobe2MVC.Models
{
    public class Wardrobe2MVCContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Wardrobe2MVCContext() : base("name=Wardrobe2MVCContext")
        {
        }

        public System.Data.Entity.DbSet<Wardrobe2MVC.Models.Shirt> Shirts { get; set; }

        public System.Data.Entity.DbSet<Wardrobe2MVC.Models.Pants> Pants { get; set; }

        public System.Data.Entity.DbSet<Wardrobe2MVC.Models.Shoes> Shoes { get; set; }

        public System.Data.Entity.DbSet<Wardrobe2MVC.Models.Accessory> Accessories { get; set; }
    }
}
