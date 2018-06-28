using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstTry.Models
{
    public class Birthday:DbContext
    {
        public DbSet<PersonModel> Persons { get; set; }
        public DbSet<Family> Families { get; set; }

    }
}