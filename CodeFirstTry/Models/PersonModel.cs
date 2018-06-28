using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstTry.Models
{
    public class PersonModel
    {
        public int PersonID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateofBirth { get; set; }

        public virtual ICollection<Family> Families { get; set; }


    }
}