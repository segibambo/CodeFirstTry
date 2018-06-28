using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstTry.Models
{
    public class Family
    {
        public int FamilyID { get; set; }

        public virtual PersonModel Person { get; set; }

    }
}