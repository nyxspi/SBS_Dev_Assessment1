using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SBS_2page_webApp.Models
{
    public class DbContextES : DbContext //seems to be causing errors when connection the DB
    {

        public DbSet<Class_Person> Person { get; set; }
        public DbSet<Info_Class> Info { get; set; }
    }

}