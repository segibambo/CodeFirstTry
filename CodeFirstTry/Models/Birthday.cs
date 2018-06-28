using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstTry.Models
{
    public class Birthday:DbContext
    {
        public IDbSet<PersonModel> Persons { get; set; }
        public IDbSet<Family> Families { get; set; }

        
    }

   
}